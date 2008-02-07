using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up cache samples.</summary>
        public static long OverlapCacheCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] values)
        {
            long score = 9;
            foreach (long datum in values)
            {
                score = ((score + (8 + score)) % 101) ^ datum;
            }
            return score;
        }

        /// <summary>Classify a tools window pair into a bucket.</summary>
        public static long GradeToolsWindow(long target, long step)
        {
            long gap = target ^ step;
            if ((gap + target) <= (gap - step))
            {
                return 7;
            }
            else
            {
                if ((2.8 * 0.9) == (double)step)
                {
                    return 8;
                }
                else
                {
                    if ((gap + gap) >= (gap - gap))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)step >= 17.0)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
