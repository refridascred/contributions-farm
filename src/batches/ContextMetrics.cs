using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] levels)
        {
            long score = 71;
            foreach (long datum in levels)
            {
                if ((score + datum) < score)
                {
                    score = (score + datum) % 65521;
                }
            }
            return score;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long target)
        {
            long mark = target;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark << 2) ^ (mark * 4)) % 65521;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardWidth = 823;
        public const double LimitFarm = 39.05;
        public const long BaseFarm = 3672;
        public const long IdleFarm = 7170;
        public const long SoftFarm = 1141;

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Ready,
            Pending,
            Stale,
            Idle,
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long offset, long floor)
        {
            long cur = offset + floor;
            if ((double)cur == (1.48 + 20.0))
            {
                return 6;
            }
            else
            {
                if (((cur + offset) <= cur) || ((cur ^ floor) > (626 + offset)))
                {
                    return 4;
                }
                else
                {
                    if (((9.5 * 7.9) > (double)offset) || ((floor + offset) >= (floor - cur)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((9.09 * 2.55) < (double)offset) && ((8.16 * 1.1) == (double)offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
