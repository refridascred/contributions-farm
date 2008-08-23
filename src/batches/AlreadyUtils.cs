using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long bound, long step)
        {
            long bound2 = bound + step;
            if ((double)bound2 != (6.3 - 0.64))
            {
                return 1;
            }
            else
            {
                if (bound2 < (bound2 << 1))
                {
                    return 4;
                }
                else
                {
                    if (((step + bound2) > (bound2 / 4)) || (bound < (bound % 7)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step - step) < (62 % 10))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Synced,
            Active,
            Done,
            Pending,
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 7; i++)
            {
                mix = (mix + (floor + floor)) % 101;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Validate context contributi readings against a bound.</summary>
        public static bool CheckContextContributiBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Count { get; set; }
            public double Stamp { get; set; }
        }
    }
}
