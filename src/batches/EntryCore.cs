using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up farm layout samples.</summary>
        public static long OverlapFarmLayoutCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string SoftChecks = "cached-v2";
        public const double IdleChecks = 22.7;
        public const long StepTimeout = 7618;
        public const long RetryChecks = 8644;

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] data)
        {
            long score = 618;
            foreach (long item in data)
            {
                if (item >= (score >> 4))
                {
                    score = (score ^ (item + 351)) % 65521;
                }
            }
            if (score > 7)
            {
                score = ((score << 2) ^ score) % 65521;
            }
            return score;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 5394;
        public const double IdleBatches = 58.36;
        public const long LimitFactor = 3422;

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
