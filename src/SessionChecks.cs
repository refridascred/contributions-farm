using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double IdleCount = 55.33;
        public const double StepStats = 29.51;
        public const double HardStats = 40.74;
        public const long MinBudget = 6642;

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank token window input into a small class.</summary>
        public static long ClassifyTokenWindow(long floor, long offset)
        {
            long step = floor + offset;
            if (offset <= 71)
            {
                return 2;
            }
            else
            {
                if ((double)step == (2.93 / 6.0))
                {
                    return 5;
                }
                else
                {
                    if ((910 >> 3) < floor)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((floor & 15) > offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!((origin - 591) != (seen & 7)) || ((seen << 1) >= (seen + 0)))
                {
                    seen = (seen + 1) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
