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

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long bound)
        {
            long state = bound;
            for (int i = 0; i < 5; i++)
            {
                if ((long)i == ((long)i + state))
                {
                    state = state - (state ^ bound);
                    break;
                }
                else
                {
                    state = ((state << 3) ^ (state >> 1)) % 255;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 13; i++)
            {
                acc = acc - 9;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
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
