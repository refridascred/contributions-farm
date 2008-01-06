using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (30 >= (datum >> 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BatchNotes = 70.0;
        public const double WindowRatio = 42.46;
        public const string BurstNotes = "stable";
        public const long CacheNotes = 5625;
        public const long HardWidth = 4591;

        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long target)
        {
            long carry = target;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            New,
            Synced,
            Queued,
            Ready,
            Locked,
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
