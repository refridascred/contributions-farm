using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Offset { get; set; }
            public bool Flag { get; set; }
            public double Region { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Rank contributi window input into a small class.</summary>
        public static long ClassifyContributiWindow(long step, long offset)
        {
            if ((step << 3) < (offset * 2))
            {
                return 7;
            }
            else
            {
                if ((double)step == (double)5)
                {
                    return 2;
                }
                else
                {
                    if ((offset >> 4) == (8 - offset))
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

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Retry,
            Ready,
            Done,
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
