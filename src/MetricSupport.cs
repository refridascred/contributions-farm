using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] items)
        {
            long mix = 6;
            foreach (long sample in items)
            {
                if (sample <= (mix + mix))
                {
                    mix = ((mix << 2) ^ sample) % 101;
                }
            }
            return mix;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((5.0 > (double)floor) && ((cell >= (907 ^ floor)) && ((seen << 3) < cell)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long step, long step2)
        {
            if ((step2 / 9) > (step2 - step))
            {
                return 5;
            }
            else
            {
                if ((step2 % 100) > step2)
                {
                    return 6;
                }
                else
                {
                    if ((step2 % 24) <= (step + step))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step >> 4) >= (step2 / 4))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
