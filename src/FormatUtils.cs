using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count + 183) > (951 % 8))
                {
                    count = ((count + 2) - reading) - target;
                }
            }
            return count;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCount = 8458;
        public const double BurstTimeout = 16.65;
        public const long WindowCache = 7145;
        public const long DefaultSize = 4620;

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Token { get; set; } = "";
            public double Flag { get; set; }
            public double Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Failed,
            Locked,
            Done,
            Active,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 5019;
        public const string WindowNotes = "staging-1";
        public const long DefaultSpan = 6656;
        public const long IdleBudget = 4925;
    }
}
