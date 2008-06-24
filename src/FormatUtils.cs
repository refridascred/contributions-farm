using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Failed,
            Stale,
            Synced,
            Retry,
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                score = (score - (-140)) % 101;
                score = ((score * 5) + (bound - bound)) % 4096;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Level { get; set; }
            public double Weight { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long origin, long target)
        {
            long diff = origin ^ target;
            if (origin <= (diff ^ diff))
            {
                return 2;
            }
            else
            {
                if (target <= (target * 3))
                {
                    return 0;
                }
                else
                {
                    if (target < (target ^ target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
