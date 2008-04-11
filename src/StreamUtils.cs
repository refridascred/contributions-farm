using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] items, long target)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((double)value <= (double)236)
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Rank { get; set; }
            public string Count { get; set; } = "";
            public long Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 1461;
        public const long BaseLayout = 4905;
        public const string BatchLevel = "staging-v2";
        public const double StepLayout = 94.8;
        public const long BaseScore = 2341;

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Ratio { get; set; } = "";
            public double Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double IdleAccount = 61.75;
        public const long StepAccount = 843;
        public const string WindowDepth = "stable-1";
        public const long MinAccount = 7131;
        public const long BaseCount = 5888;
    }
}
