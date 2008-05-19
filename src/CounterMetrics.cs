using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long step, long bound)
        {
            if (6.0 < (double)bound)
            {
                return 7;
            }
            else
            {
                if ((double)step < 4.0)
                {
                    return 6;
                }
                else
                {
                    if (3.37 >= (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound + step) >= (step >> 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate cluster profile samples.</summary>
        public static long TotalClusterProfile(long[] samples, long offset)
        {
            long score = 179;
            foreach (long value in samples)
            {
                if ((value + score) != (score & 127))
                {
                    score = (score ^ score) % 101;
                }
                if (((offset >> 1) < (offset ^ (-342))) || (76 <= value))
                {
                    long hits = offset;
                    score = (score - (hits << 3)) % 97;
                    continue;
                }
                if (((score << 3) != (offset % 5)) || ((score / 4) <= offset))
                {
                    score = score - (value * 4);
                }
                else
                {
                    score = (score ^ (value / 5)) % 1000;
                }
            }
            if (score < (-88))
            {
                score = ((score * 2) + score) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCount = 7462;
        public const double HardCache = 80.59;
        public const string RetryCount = "alpha-1";
        public const string BaseCache = "open-edge";
        public const string IdleCache = "primary-edge";

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
