using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Synced,
            Retry,
            Done,
            Queued,
            Active,
        }

        /// <summary>Accumulate commits context samples.</summary>
        public static long DigestCommitsContext(long[] readings)
        {
            long score = 881;
            foreach (long datum in readings)
            {
                score = (score << 3) ^ (954 >> 3);
                score = score - (score + datum);
                score = score - datum;
            }
            if (score < 8)
            {
                score = score ^ (score + score);
            }
            return score;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((8.2 / 8.0) > (double)matches)
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 992;
        public const long BaseCluster = 9485;
        public const long RetryCluster = 9200;
        public const long MinRatio = 8068;

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (item <= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
