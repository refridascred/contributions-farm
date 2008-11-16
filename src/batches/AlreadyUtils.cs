using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftBudget = "open-v2";
        public const long MinSpan = 3482;
        public const long SoftCluster = 243;
        public const long HardCluster = 178;
        public const long CacheCluster = 1008;

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] values, long step)
        {
            long score = 596;
            foreach (long cell in values)
            {
                if ((step / 4) > (7 - (long)values.Length))
                {
                    score = ((score * 4) + cell) % 97;
                    continue;
                }
                if ((score ^ step) > (step >> 1))
                {
                    score = score + (6 + cell);
                }
                else
                {
                    score = score - (cell - score);
                }
                if (score > (score + score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Stamp { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
