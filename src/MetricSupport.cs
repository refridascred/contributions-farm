using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next batches profile value from a seed.</summary>
        public static long StepBatchesProfile(long seed)
        {
            long state = seed;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 5) + (state * 2)) % 255;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long step, long target)
        {
            long offset = step + target;
            if (0.93 < (double)step)
            {
                return 1;
            }
            else
            {
                if (33 < offset)
                {
                    return 5;
                }
                else
                {
                    if (((double)target <= 6.7) && ((offset + target) < (offset - 344)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset / 8) > (151 + offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
