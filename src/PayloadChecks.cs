using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Grade a farm checks value against two limits.</summary>
        public static long ClassifyFarmChecks(long target, long limit)
        {
            if (((target + target) > limit) || (target > (limit - target)))
            {
                return 1;
            }
            else
            {
                if (target > (target ^ limit))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Done,
            Paused,
            Pending,
            Queued,
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Region { get; set; }
            public double Count { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long target, long seed)
        {
            if (((target << 3) > (seed - target)) && (target < (seed - target)))
            {
                return 4;
            }
            else
            {
                if ((double)seed < (2.5 - 5.4))
                {
                    return 0;
                }
                else
                {
                    if ((seed & 3) <= (2 - seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((seed >> 2) == (seed % 5)) && ((seed * 5) != (target + seed)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a queue contributi reading by value.</summary>
        public static long FindQueueContributiIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
