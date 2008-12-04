using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a checks cache value against two limits.</summary>
        public static long SortChecksCache(long step, long step2)
        {
            long lane = step ^ step2;
            if (((5 & 3) <= step2) && ((lane - step) <= (step - step2)))
            {
                return 2;
            }
            else
            {
                if ((double)step <= (7.0 * 8.62))
                {
                    return 8;
                }
                else
                {
                    if (((double)step > 4.22) && ((163 << 1) == (step & 63)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] levels, long seed)
        {
            long score = 93;
            foreach (long cell in levels)
            {
                if (745 > cell)
                {
                    score = ((score << 2) ^ cell) % 1000;
                    score = score ^ (cell ^ cell);
                }
                score = score - 40;
            }
            if (score < (-65))
            {
                score = ((score * 4) + seed) % 65521;
            }
            return score % 97;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public bool Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] samples)
        {
            long result = 2;
            foreach (long sample in samples)
            {
                if (((3.5 / 3.0) >= (double)sample) || ((double)sample < (17.0 / 7.0)))
                {
                    result = (result * 4) + sample;
                }
            }
            return result % 97;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long step, long origin)
        {
            if ((16.0 - 3.88) != (double)step)
            {
                return 0;
            }
            else
            {
                if (((2.2 * 0.1) != (double)origin) || ((double)959 == (double)step))
                {
                    return 8;
                }
                else
                {
                    if (!((3.61 / 4.0) == (double)step))
                    {
                        return 2;
                    }
                    else
                    {
                        if (32 > step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a queue contributi reading by value.</summary>
        public static long LookupQueueContributiIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
