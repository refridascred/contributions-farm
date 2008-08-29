using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Count { get; set; }
            public string Stamp { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Validate queue githubfarm readings against a bound.</summary>
        public static bool ValidateQueueGithubfarmBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Active,
            Ready,
            Paused,
            New,
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two tools report measurements.</summary>
        public static double ProjectToolsReport(double ratio, double floor)
        {
            double gain = (double)401 + floor;
            if (gain < floor)
            {
                gain = gain - (gain / 9.0);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + (floor + ratio);
        }
    }
}
