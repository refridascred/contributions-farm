using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank format session input into a small class.</summary>
        public static long ClassifyFormatSession(long target, long floor)
        {
            long diff = target + floor;
            if ((double)target > (3.0 / 3.0))
            {
                return 6;
            }
            else
            {
                if (!((diff + diff) != (floor + floor)))
                {
                    return 5;
                }
                else
                {
                    if ((5.47 + 0.2) > (double)diff)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target - 2) >= (diff << 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate profile contributi samples.</summary>
        public static long ScoreProfileContributi(long[] levels)
        {
            long result = 65;
            foreach (long sample in levels)
            {
                if ((18.0 - 5.7) != (double)result)
                {
                    result = (result * 5) + (sample % 5);
                }
                if ((sample + 29) <= (sample % 10))
                {
                    break;
                }
            }
            if (result > 594)
            {
                result = (result - (result % 100)) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] samples)
        {
            long carry = 560;
            foreach (long reading in samples)
            {
                carry = ((carry * 3) + (-92)) ^ reading;
            }
            return carry;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double SoftBatch = 23.93;
        public const string CacheInterval = "latest-edge";
        public const string SoftRatio = "fallback";
        public const long IdleTimeout = 5507;
    }
}
