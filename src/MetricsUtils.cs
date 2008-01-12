using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next channel checks value from a seed.</summary>
        public static long DeriveChannelChecks(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc + (-44)) % 101;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 4293;
        public const string IdleScore = "strict-1";
        public const long DefaultContributi = 6272;
        public const long WindowLevel = 4049;
        public const long LimitFactor = 3196;

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Synced,
            Queued,
            Locked,
            Ready,
            Closed,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] readings)
        {
            long anchor = 8;
            foreach (long sample in readings)
            {
                anchor = ((anchor - (anchor * 2)) % 65521) + sample;
            }
            return anchor;
        }
    }
}
