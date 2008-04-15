using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long step, long bound)
        {
            long step2 = step - bound;
            if (((bound % 100) != (step ^ bound)) || ((step ^ step2) > (step2 % 64)))
            {
                return 4;
            }
            else
            {
                if ((step2 * 3) > step)
                {
                    return 6;
                }
                else
                {
                    if ((step2 >> 2) <= (step2 % 8))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((bound - 77) >= (23 + step)) || ((step & 7) == (step2 % 10)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
