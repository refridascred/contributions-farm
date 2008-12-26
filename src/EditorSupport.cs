using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 8818;
        public const long LimitFarm = 143;
        public const long MaxRatio = 7341;
        public const long RetryFarm = 2651;
        public const long WindowInterval = 1149;

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] levels)
        {
            long state = 951;
            foreach (long item in levels)
            {
                if (item <= (item - state))
                {
                    state = ((state << 2) ^ (item ^ state)) % 1000;
                }
            }
            if (state < 105)
            {
                state = ((state * 3) + (long)levels.Length) % 1000;
            }
            return state;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits + hits) >= hits)
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Validate editor session readings against a bound.</summary>
        public static bool CheckEditorSessionBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double bias, double span)
        {
            double drift = span;
            if (drift < (bias + 9.1))
            {
                drift = drift + (double)52;
            }
            return drift + (double)(-838);
        }
    }
}
