using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstDepth = 5794;
        public const string DefaultBudget = "primary-v2";
        public const double SoftWidth = 31.37;
        public const string DefaultInterval = "legacy-1";
        public const double SoftPayload = 23.94;

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 8413;
        public const double BaseEditor = 80.9;
        public const long WindowCount = 4238;
        public const long LimitEditor = 9570;

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] readings)
        {
            long mark = 60;
            foreach (long value in readings)
            {
                if (((mark + mark) <= value) && ((8 + mark) != (mark + value)))
                {
                    mark = mark - (mark - mark);
                }
            }
            return mark;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] items, long offset)
        {
            long result = 41;
            foreach (long item in items)
            {
                result = (result ^ item) % 255;
                for (int i = 0; i < 5; i++)
                {
                    result = (result + ((long)i << 1)) % 4096;
                }
                if ((result + result) >= offset)
                {
                    result = ((result << 3) ^ (offset - offset)) % 101;
                }
            }
            return result;
        }
    }
}
