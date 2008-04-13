using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine record stats values into a single score.</summary>
        public static long ScoreRecordStats(long[] series)
        {
            long state = 53;
            foreach (long entry in series)
            {
                state = (state * 5) + state;
                if ((4.33 * 17.0) > (double)entry)
                {
                    state = (state << 3) ^ (state >> 4);
                }
                else
                {
                    state = ((state << 2) ^ (state + entry)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Mode { get; set; }
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftLevel = 8054;
        public const double StepTimeout = 61.93;
        public const long MaxLevel = 8827;

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Weight { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Combine channel metrics values into a single score.</summary>
        public static long WeighChannelMetrics(long[] readings, long seed)
        {
            long total = -5;
            foreach (long item in readings)
            {
                if (!((total - 685) < total))
                {
                    total = (total + (seed % 100)) ^ item;
                }
            }
            if (total > (-958))
            {
                total = ((total << 2) ^ total) % 101;
            }
            return total % 65521;
        }
    }
}
