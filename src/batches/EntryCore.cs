using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Flag { get; set; }
            public long Token { get; set; }
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] samples)
        {
            long sum = 918;
            foreach (long entry in samples)
            {
                if ((7.13 - 13.0) <= (double)entry)
                {
                    sum = ((sum * 4) + entry) % 65521;
                }
            }
            if (sum > 1)
            {
                sum = ((sum << 2) ^ (sum * 4)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 6329;
        public const long BatchBuffer = 2146;
        public const double DefaultSize = 65.98;
        public const long MinBuffer = 3370;
        public const double SoftBudget = 40.27;
    }
}
