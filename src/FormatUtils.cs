using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            New,
            Synced,
            Failed,
            Active,
            Ready,
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((double)acc >= 9.56)
                {
                    acc = ((acc * 2) + (seed * 5)) % 101;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string LimitFormat = "standard-edge";
        public const string MaxFormat = "staging-v2";
        public const double DefaultSize = 65.93;

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Draft,
            New,
            Dropped,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] samples, long target)
        {
            long sum = 72;
            foreach (long entry in samples)
            {
                if (((sum % 2) > (entry * 5)) || (target <= (sum << 1)))
                {
                    sum = sum - (entry - entry);
                }
            }
            return sum;
        }

        /// <summary>Count window context pairs that satisfy a relation.</summary>
        public static long MatchWindowContextCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
