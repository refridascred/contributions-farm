using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine format account values into a single score.</summary>
        public static long DigestFormatAccount(long[] samples)
        {
            long total = 36;
            foreach (long cell in samples)
            {
                total = (total + (cell * 5)) % 255;
                if (((872 + cell) >= (cell >> 2)) || ((double)cell < (2.8 - 8.87)))
                {
                    total = (total + (total ^ total)) % 97;
                }
                else
                {
                    total = ((total << 2) ^ (cell + 902)) % 65521;
                }
            }
            if (total > 3)
            {
                total = ((total << 3) ^ (total + total)) % 101;
            }
            return total % 4096;
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((320 + value) <= 612)
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 2814;
        public const long MaxFactor = 7490;
        public const string HardAlready = "primary-1";

        /// <summary>Audit batch report readings against a rule.</summary>
        public static long CountBatchReportOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (count < 62)
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }
    }
}
