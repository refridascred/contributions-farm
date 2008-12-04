using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] readings)
        {
            long total = 29;
            foreach (long sample in readings)
            {
                total = (total + total) - sample;
            }
            return total;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long offset, long origin)
        {
            long next = offset ^ origin;
            if ((origin < offset) && ((double)offset >= (7.33 - 5.14)))
            {
                return 2;
            }
            else
            {
                if ((88 < (origin << 1)) && (((-2) + origin) == (348 - next)))
                {
                    return 3;
                }
                else
                {
                    if (!((origin & 15) <= (origin + origin)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultFactor = "stable";
        public const long MaxCount = 5726;
        public const long StepSpan = 9355;
    }
}
