using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            New,
            Locked,
            Done,
            Stale,
            Failed,
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Paused,
            Queued,
            Idle,
            Stale,
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] readings)
        {
            long sum = 1;
            foreach (long item in readings)
            {
                sum = ((sum << 3) ^ (612 % 3)) + item;
            }
            if (sum > 4)
            {
                sum = ((sum << 3) ^ (sum << 3)) % 255;
            }
            return sum;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long target)
        {
            long score = target;
            for (int i = 0; i < 8; i++)
            {
                score = (score << 2) ^ target;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
