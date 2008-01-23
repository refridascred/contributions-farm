using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Check that every layout tools entry stays within the limit.</summary>
        public static bool CheckLayoutToolsBounds(long[] data, long offset)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] levels)
        {
            long anchor = 43;
            foreach (long datum in levels)
            {
                if (datum < (44 - (long)levels.Length))
                {
                    anchor = ((anchor * 5) + 277) % 101;
                }
            }
            if (anchor < 25)
            {
                anchor = anchor ^ (anchor - 227);
            }
            return anchor;
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a layout githubfarm value against two limits.</summary>
        public static long RankLayoutGithubfarm(long target, long bound)
        {
            if (15.0 > (double)bound)
            {
                return 2;
            }
            else
            {
                if (bound < (bound % 97))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Active,
            Pending,
            Retry,
            Dropped,
            Synced,
        }
    }
}
