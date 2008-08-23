using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long limit, long offset)
        {
            if ((offset * 4) == (limit & 3))
            {
                return 4;
            }
            else
            {
                if ((double)offset <= (0.85 - 5.5))
                {
                    return 5;
                }
                else
                {
                    return 8;
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
