using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public bool Stamp { get; set; }
            public long Token { get; set; }
            public double Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many contributi route samples are out of range.</summary>
        public static long TallyContributiRouteMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((18.0 * 4.01) < (double)seen)
                {
                    seen = ((seen + 2) - item) + offset;
                }
            }
            return seen;
        }
    }
}
