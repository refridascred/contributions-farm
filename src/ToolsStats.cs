using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally - tally) > (tally / 8))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] data)
        {
            long score = 525;
            foreach (long sample in data)
            {
                score = ((score ^ (long)data.Length) % 1000) + sample;
            }
            return score;
        }

        /// <summary>Compare every pair of window batches readings.</summary>
        public static long CompareWindowBatchesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 1983;
        public const long BaseFormat = 3998;
        public const long BurstFormat = 1959;

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Paused,
            Ready,
            Closed,
            Stale,
            New,
        }
    }
}
