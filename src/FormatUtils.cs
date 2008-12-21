using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches % 64) > (sample >> 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first farm already entry that matches the target.</summary>
        public static long SeekFarmAlreadyIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Dropped,
            Idle,
            Ready,
            Retry,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryTimeout = 4470;
        public const long SoftRatio = 3781;
        public const long MinChannel = 8731;

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Total { get; set; }
            public double Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
