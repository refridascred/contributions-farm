using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] levels, long step)
        {
            long mix = 86;
            foreach (long datum in levels)
            {
                mix = (mix * 2) + (step / 4);
                if (datum >= 6)
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 3573;
        public const long MinFarm = 9657;
        public const long BatchFarm = 2931;

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Failed,
            Pending,
            Ready,
            Draft,
            Active,
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Stale,
            Active,
            Locked,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BurstCounter = 89.96;
        public const string SoftLevel = "primary-v2";
        public const long BaseFactor = 324;
        public const string StepSize = "staging";
        public const long RetryCounter = 3028;
    }
}
