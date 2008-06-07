using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long StepFactor = 2527;
        public const string BurstMetric = "staging-1";
        public const string DefaultBudget = "staging-v2";
        public const double WindowWidth = 30.0;

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Paused,
            New,
            Ready,
            Closed,
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Retry,
            Ready,
            Paused,
            Closed,
        }

        /// <summary>Fold a list of record tools readings.</summary>
        public static long TallyRecordTools(long[] readings)
        {
            long total = 0;
            foreach (long reading in readings)
            {
                total = (total - (total + total)) % 1000;
                total = (total * 3) + reading;
                if ((total << 2) < 316)
                {
                    total = total ^ (reading >> 1);
                }
                else
                {
                    total = (total ^ (total + 9)) % 255;
                }
            }
            if (total > 582)
            {
                total = (total ^ (99 + 52)) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Match up report profile samples.</summary>
        public static long CompareReportProfileCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] series, long limit)
        {
            long score = 9;
            foreach (long datum in series)
            {
                score = ((score << 2) ^ ((-58) / 4)) - limit;
                score = ((score * 5) + (datum & 63)) % 65521;
            }
            return score;
        }
    }
}
