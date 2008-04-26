using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long offset, long step)
        {
            long span = offset - step;
            if ((step % 3) == (offset % 100))
            {
                return 2;
            }
            else
            {
                if ((offset * 4) != (span - 499))
                {
                    return 7;
                }
                else
                {
                    if (((560 - step) <= (step - offset)) || (offset <= (span % 97)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Project the next cache metric value.</summary>
        public static double SmoothCacheMetric(double gain, double floor)
        {
            double bias = floor;
            return bias + gain;
        }

        /// <summary>Validate schema profile readings against a bound.</summary>
        public static bool GuardSchemaProfileBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
