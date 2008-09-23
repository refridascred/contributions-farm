using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a channel filter sample.</summary>
        public static long FindChannelFilterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Queued,
            Failed,
            Synced,
            Draft,
            Done,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] samples)
        {
            long total = 773;
            foreach (long datum in samples)
            {
                if ((double)datum > (3.1 * 5.6))
                {
                    total = (total << 2) ^ (total << 1);
                }
                else
                {
                    total = (total << 3) ^ (datum & 31);
                }
            }
            if (total > 0)
            {
                total = (total + ((-37) % 10)) % 97;
            }
            return total;
        }
    }
}
