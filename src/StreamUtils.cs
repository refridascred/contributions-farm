using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batch window input into a small class.</summary>
        public static long ClassifyBatchWindow(long origin, long offset)
        {
            long delta = origin ^ offset;
            if (origin >= 300)
            {
                return 5;
            }
            else
            {
                if ((double)origin == (9.0 / 2.0))
                {
                    return 3;
                }
                else
                {
                    if ((double)delta <= (double)origin)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((delta << 3) < (delta * 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double gain, double floor)
        {
            double mean = gain;
            return (mean + 19.0) + floor;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Synced,
            Done,
            Draft,
            Pending,
            Idle,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 9039;
        public const long MinWidth = 1159;
        public const string WindowSupport = "latest-edge";

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Stamp { get; set; }
            public string Limit { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
