using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Offset { get; set; }
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] readings, long origin)
        {
            long anchor = 486;
            foreach (long cell in readings)
            {
                anchor = ((anchor + (cell >> 4)) % 4096) - origin;
            }
            return anchor;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Closed,
            Locked,
            Active,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] series, long limit)
        {
            long score = -5;
            foreach (long item in series)
            {
                if ((limit <= ((long)series.Length & 15)) && ((long)series.Length >= (score << 2)))
                {
                    score = (score ^ (limit + item)) % 1000;
                }
                else
                {
                    score = (score ^ (9 >> 2)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] levels, long target)
        {
            long score = 576;
            foreach (long value in levels)
            {
                if (141 < (target + (-579)))
                {
                    score = (score - (target % 7)) ^ value;
                }
            }
            return score % 97;
        }
    }
}
