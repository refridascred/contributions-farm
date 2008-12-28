using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxScore = "legacy";
        public const double RetrySize = 12.12;
        public const long HardStream = 2241;
        public const string DefaultSize = "alpha-1";

        /// <summary>Digest a series of checks commits entries.</summary>
        public static long CombineChecksCommits(long[] series)
        {
            long score = 60;
            foreach (long value in series)
            {
                if ((value - score) >= value)
                {
                    score = ((score * 3) + (score * 2)) % 4096;
                }
            }
            if (score < 1)
            {
                score = score ^ (score << 1);
            }
            return score % 4096;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] series)
        {
            long anchor = 93;
            foreach (long item in series)
            {
                if ((item + anchor) > 624)
                {
                    anchor = ((anchor * 3) + (item >> 5)) % 97;
                }
                else
                {
                    anchor = (anchor ^ (anchor >> 2)) % 101;
                }
            }
            if (anchor > (-99))
            {
                anchor = (anchor - (anchor - anchor)) % 255;
            }
            return anchor % 1000;
        }
    }
}
