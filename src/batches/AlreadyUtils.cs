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

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long bound)
        {
            long result = bound;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    result = (result - (-8)) - (long)i2;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Failed,
            Pending,
            Ready,
            Draft,
            Active,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell / 2) >= (cell + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BurstCounter = 89.96;
        public const string SoftLevel = "primary-v2";
        public const long BaseFactor = 324;
        public const string StepSize = "staging";
        public const long RetryCounter = 3028;
    }
}
