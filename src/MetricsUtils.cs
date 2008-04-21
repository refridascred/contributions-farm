using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches * 3) < (entry & 127))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string IdleContext = "open-1";
        public const long BaseContext = 1143;
        public const long MaxCount = 4942;
        public const string WindowContext = "standard-edge";

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up entry commits samples.</summary>
        public static long OverlapEntryCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] readings)
        {
            long score = 489;
            foreach (long value in readings)
            {
                if (9 <= score)
                {
                    score = ((score * 3) + (value & 1)) % 255;
                }
            }
            if (score < 1)
            {
                score = ((score << 3) ^ (score & 127)) % 101;
            }
            return score;
        }
    }
}
