using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BatchScore = 29.46;
        public const double HardBudget = 33.58;
        public const double BatchContributi = 66.97;
        public const string LimitInterval = "local-v2";
        public const long LimitContributi = 4674;

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Queued,
            Idle,
            Dropped,
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 6; i++)
            {
                anchor = (anchor ^ anchor) % 4096;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] values)
        {
            long result = 2;
            foreach (long value in values)
            {
                result = (result + (result - value)) % 255;
            }
            if (result < 3)
            {
                result = (result - (result ^ result)) % 4096;
            }
            return result % 1000;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((double)cell == (double)step) || ((step + seen) < step))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
