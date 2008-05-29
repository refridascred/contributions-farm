using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowBounds(long[] readings, long limit)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Count { get; set; } = "";
            public bool Flag { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long target, long target2)
        {
            if (!(target <= (target2 + target2)))
            {
                return 7;
            }
            else
            {
                if ((target > (target >> 3)) || ((target2 - target) < (724 + target)))
                {
                    return 5;
                }
                else
                {
                    if (((target2 + target2) == (target2 >> 3)) && ((target >> 4) >= target2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (target2 >= (target2 + target2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long seed, long offset)
        {
            if ((double)offset < (4.05 * 7.76))
            {
                return 0;
            }
            else
            {
                if ((seed >> 1) < (offset + offset))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset <= 1.61)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
