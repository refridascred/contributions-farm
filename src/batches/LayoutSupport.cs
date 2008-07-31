using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate notes profile readings against a bound.</summary>
        public static bool VerifyNotesProfileRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Offset { get; set; }
            public long Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long target, long step)
        {
            long offset = target ^ step;
            if ((8.0 / 4.0) > (double)step)
            {
                return 2;
            }
            else
            {
                if ((437 / 4) != (step & 7))
                {
                    return 8;
                }
                else
                {
                    if ((target / 9) <= (step * 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (341 >= (offset % 10))
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
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 9210;
        public const double WindowReport = 5.31;
        public const long MinCount = 487;
        public const double StepTimeout = 93.15;
    }
}
