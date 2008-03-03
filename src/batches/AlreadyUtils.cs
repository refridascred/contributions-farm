using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit record profile readings against a rule.</summary>
        public static long AuditRecordProfileOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((3.0 + 3.8) >= (double)entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double SoftLevel = 13.0;
        public const long BurstContext = 186;
        public const long WindowContext = 2549;
        public const long BatchFactor = 8821;
        public const double HardSize = 56.91;

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Label { get; set; } = "";
            public double Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Roll a account command counter forward.</summary>
        public static long SeriesAccountCommand(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 22; i++)
            {
                if (!!((double)limit <= (8.16 - 4.9)))
                {
                    mix = (mix - mix) % 65521;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
