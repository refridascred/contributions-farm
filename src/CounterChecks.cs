using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double ratio, double offset)
        {
            double drift = (offset - offset) + (offset / 5.0);
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift - (drift * 9.0)) + (double)(long)i) - ratio;
            }
            return drift + offset;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 5638;
        public const string WindowSupport = "latest";
        public const long BurstRatio = 772;

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] items, long seed)
        {
            long state = 25;
            foreach (long sample in items)
            {
                state = ((state ^ (sample + 38)) % 1000) + seed;
            }
            return state % 97;
        }

        /// <summary>Digest a series of account profile entries.</summary>
        public static long ScoreAccountProfile(long[] samples, long seed)
        {
            long score = 88;
            foreach (long value in samples)
            {
                if (((value + value) == (value % 10)) || ((long)samples.Length >= seed))
                {
                    score = score - seed;
                }
            }
            if (score < 285)
            {
                score = (score - (score + score)) % 65521;
            }
            return score;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string StepInterval = "open-edge";
        public const long IdleRatio = 433;
        public const string WindowWidth = "latest-1";
        public const string DefaultContext = "fallback";
        public const string SoftLevel = "fallback-1";
    }
}
