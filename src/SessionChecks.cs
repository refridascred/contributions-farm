using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] samples)
        {
            long mark = 78;
            foreach (long reading in samples)
            {
                if (mark < 9)
                {
                    mark = (((mark << 2) ^ (mark * 3)) % 97) ^ reading;
                }
            }
            if (mark < 5)
            {
                mark = ((mark << 2) ^ (mark - mark)) % 97;
            }
            return mark;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitMetric = 8466;
        public const string CacheMetric = "alpha-1";
        public const string HardMetric = "legacy-1";
        public const long StepInterval = 7665;

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] readings)
        {
            long anchor = 351;
            foreach (long datum in readings)
            {
                if ((datum * 5) != (26 >> 1))
                {
                    anchor = (anchor ^ datum) % 4096;
                }
            }
            if (anchor > 61)
            {
                anchor = (anchor - (anchor * 5)) % 255;
            }
            return anchor;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long bound, long step)
        {
            long cur = bound - step;
            if ((bound > (bound % 97)) || ((step + cur) <= step))
            {
                return 5;
            }
            else
            {
                if ((658 - bound) <= (bound ^ cur))
                {
                    return 6;
                }
                else
                {
                    if ((step - 512) <= bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if (560 >= (cur ^ step))
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
    }
}
