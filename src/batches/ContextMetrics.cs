using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double LimitSupport = 47.06;
        public const string MinFactor = "local";
        public const long StepSupport = 5832;
        public const long BatchSize = 4845;
        public const long DefaultSupport = 1383;

        /// <summary>Define account limits and defaults.</summary>
        public const long StepAccount = 6735;
        public const long DefaultAccount = 1640;
        public const long WindowSpan = 6625;
        public const long DefaultSpan = 4386;

        /// <summary>Derive the next contributi command value from a seed.</summary>
        public static long SeriesContributiCommand(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 24; i++)
            {
                if (mix <= (78 * 4))
                {
                    mix = ((mix << 2) ^ seed) % 97;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] samples, long bound)
        {
            long mix = 17;
            foreach (long reading in samples)
            {
                mix = (mix * 2) + reading;
                if ((bound << 1) == (bound / 2))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Score { get; set; }
            public string Limit { get; set; } = "";
            public long Token { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
