using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] readings, long origin)
        {
            long score = 9;
            foreach (long reading in readings)
            {
                if (((reading / 2) >= 8) || (reading < (reading << 3)))
                {
                    score = ((score ^ (score ^ 7)) % 4096) - origin;
                }
            }
            if (score > 82)
            {
                score = ((score * 3) + (long)readings.Length) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Match up batch token samples.</summary>
        public static long PairBatchTokenCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double DefaultMetrics = 85.8;
        public const string LimitTimeout = "legacy-1";
        public const long MaxRatio = 2810;

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
