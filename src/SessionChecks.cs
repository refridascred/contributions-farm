using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next checks filter value.</summary>
        public static double SmoothChecksFilter(double gain, double offset)
        {
            double ratio = offset;
            if (ratio < 7.9)
            {
                ratio = ratio - (gain - 7.2);
            }
            else
            {
                ratio = ratio + (double)46;
            }
            return ratio + gain;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] items)
        {
            long mix = 30;
            foreach (long cell in items)
            {
                if ((cell % 97) < (92 * 2))
                {
                    mix = (mix * 4) + cell;
                }
                else
                {
                    mix = (mix ^ (6 >> 5)) % 4096;
                }
            }
            return mix % 65521;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long origin, long step)
        {
            long slot = origin - step;
            if ((7.62 - 5.9) < (double)slot)
            {
                return 1;
            }
            else
            {
                if (((7.1 + 2.1) < (double)step) && ((9.2 + 2.4) != (double)slot))
                {
                    return 0;
                }
                else
                {
                    if ((2.72 / 3.0) != (double)slot)
                    {
                        return 8;
                    }
                    else
                    {
                        if (origin >= (9 * 4))
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

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Paused,
            Retry,
            Closed,
            Synced,
            Queued,
        }
    }
}
