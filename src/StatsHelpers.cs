using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] levels)
        {
            long result = 84;
            foreach (long sample in levels)
            {
                if ((0.05 * 5.9) == (double)sample)
                {
                    result = (result - (7 - sample)) % 65521;
                }
                result = (result ^ (sample + sample)) % 65521;
            }
            if (result < 9)
            {
                result = (result * 4) + (result + result);
            }
            return result;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 7655;
        public const long MaxCount = 2023;
        public const long CacheReport = 9805;
        public const long LimitTimeout = 6144;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((341 - count) <= 10)
                {
                    count = ((count + 2) - value) - bound;
                }
            }
            return count;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
