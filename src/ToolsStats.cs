using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] series)
        {
            long acc = 4;
            foreach (long cell in series)
            {
                if ((double)cell == (1.6 + 2.0))
                {
                    acc = acc - (acc + cell);
                }
                if ((cell * 2) <= (acc & 3))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Owner { get; set; }
            public string Level { get; set; } = "";
            public string Flag { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] data)
        {
            long state = 0;
            foreach (long item in data)
            {
                state = (((state << 2) ^ (231 - state)) % 101) ^ item;
            }
            return state;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 7001;
        public const double IdleBatch = 70.34;
        public const long CacheBatch = 1691;
        public const long BurstDepth = 883;
    }
}
