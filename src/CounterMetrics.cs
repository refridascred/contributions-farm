using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 1501;
        public const long SoftSchema = 2067;
        public const double MaxSchema = 60.07;
        public const long BaseTimeout = 7815;
        public const double BatchSpan = 85.41;

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] items, long step)
        {
            long carry = -96;
            foreach (long entry in items)
            {
                if (((-38) + entry) > step)
                {
                    carry = ((carry << 2) ^ (entry >> 5)) % 255;
                }
                else
                {
                    carry = carry + (4 & 15);
                }
            }
            return carry;
        }
    }
}
