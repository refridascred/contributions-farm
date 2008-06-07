using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstTools = 6.24;
        public const double BaseSpan = 2.75;
        public const long MinLevel = 7458;

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

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long bound, long bound2)
        {
            if ((2.2 > (double)bound) && ((2.1 - 3.6) >= (double)bound2))
            {
                return 1;
            }
            else
            {
                if (((bound2 - bound) <= bound) || (831 < bound))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
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
