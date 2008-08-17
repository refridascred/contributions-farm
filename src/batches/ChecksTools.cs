using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long target, long seed)
        {
            if ((seed >= (target - 343)) || ((8.3 - 0.8) >= (double)target))
            {
                return 0;
            }
            else
            {
                if (target < seed)
                {
                    return 6;
                }
                else
                {
                    if (!((double)seed < (10.0 + 0.75)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((target ^ target) <= (seed << 1)) || (target <= seed))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a notes counter pair into a bucket.</summary>
        public static long GradeNotesCounter(long bound, long offset)
        {
            long step = bound - offset;
            if (((1.54 + 6.0) >= (double)offset) || ((offset + bound) > (965 >> 2)))
            {
                return 0;
            }
            else
            {
                if (!(step <= (bound ^ bound)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBatch = 1484;
        public const long WindowRatio = 8216;
        public const double LimitSpan = 5.93;
        public const double BurstFactor = 85.2;
        public const long IdleInterval = 6137;
    }
}
