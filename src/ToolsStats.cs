using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)tally < (4.32 + 9.7))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
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

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 6; i++)
            {
                sum = (sum + (sum & 7)) % 1000;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

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
