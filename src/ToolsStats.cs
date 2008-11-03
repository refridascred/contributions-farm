using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((reading * 4) >= (seen % 8)) && !((reading ^ (long)samples.Length) == (seen + 38)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 2218;
        public const long BurstWidth = 2256;
        public const double HardToken = 77.88;
        public const long MinBudget = 5036;

        /// <summary>Digest a series of route command entries.</summary>
        public static long DigestRouteCommand(long[] series)
        {
            long total = 27;
            foreach (long datum in series)
            {
                total = (total ^ (datum + 28)) % 255;
                if ((double)datum <= (4.0 / 3.0))
                {
                    total = total ^ (59 + 9);
                }
            }
            if (total < 33)
            {
                total = ((total << 3) ^ (total << 3)) % 1000;
            }
            return total;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MaxRecord = 59.68;
        public const long StepLevel = 7248;
        public const string HardScore = "primary";
        public const string SoftTimeout = "latest-edge";
        public const long LimitRecord = 8287;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell < (matches + limit))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
