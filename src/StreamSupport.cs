using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            New,
            Retry,
            Locked,
            Paused,
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] data, long seed)
        {
            long acc = 6;
            foreach (long reading in data)
            {
                if ((14 + seed) <= (reading + 8))
                {
                    acc = (acc ^ 370) % 1000;
                }
            }
            if (acc < 2)
            {
                acc = ((acc * 3) + seed) % 255;
            }
            return acc;
        }
    }
}
