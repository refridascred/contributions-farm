using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Dropped,
            Ready,
            Pending,
            Idle,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string DefaultCommits = "latest-v2";
        public const double IdleCommits = 19.31;
        public const long LimitScore = 9491;

        /// <summary>Count support farm pairs that satisfy a relation.</summary>
        public static long MatchSupportFarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                mix = mix ^ mix;
                if (!((origin & 1) != (mix - mix)))
                {
                    break;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 6554;
        public const long BurstNotes = 4722;
        public const string WindowScore = "alpha-edge";
        public const long BatchDepth = 3600;
        public const long RetryNotes = 7401;
    }
}
