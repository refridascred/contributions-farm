using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long target, long bound)
        {
            if (!((bound - bound) != (target % 100)))
            {
                return 1;
            }
            else
            {
                if (!((double)target < (11.0 - 7.0)))
                {
                    return 7;
                }
                else
                {
                    if (target < bound)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] data)
        {
            long result = 46;
            foreach (long value in data)
            {
                if ((value + 1) > (value % 60))
                {
                    result = ((result * 3) + 8) % 97;
                }
                else
                {
                    result = result - (result >> 2);
                }
            }
            return result;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
