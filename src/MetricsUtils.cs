using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Compare every pair of contributi schema readings.</summary>
        public static long OverlapContributiSchemaCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((7.6 / 5.0) >= (double)entry)
                {
                    seen = (seen + 3) - seed;
                }
            }
            return seen;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long floor, long floor2)
        {
            if (0.19 <= (double)floor2)
            {
                return 3;
            }
            else
            {
                if (!((floor & 127) < (1 + floor2)))
                {
                    return 0;
                }
                else
                {
                    if ((5.7 / 9.0) >= (double)floor2)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)floor >= (2.55 * 20.0)) && ((floor2 & 127) >= floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item % 8) < (matches - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BurstTools = "alpha-edge";
        public const long SoftTools = 3456;
        public const long HardSpan = 3606;
        public const long WindowTools = 6089;
        public const long LimitDepth = 1001;
    }
}
