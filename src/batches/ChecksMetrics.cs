using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a checks command counter forward.</summary>
        public static long DeriveChecksCommand(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (acc ^ limit) + (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Active,
            New,
            Ready,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleCommits = "fallback-edge";
        public const double BaseScore = 69.47;
        public const long DefaultLevel = 4601;
        public const long LimitCommits = 5012;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long target, long step)
        {
            if (target >= (target % 5))
            {
                return 5;
            }
            else
            {
                if (!(target < (target + target)))
                {
                    return 8;
                }
                else
                {
                    if ((double)step > (16.0 + 0.5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 7160;
        public const long HardDepth = 4557;
        public const long SoftDepth = 3031;
        public const long WindowFactor = 4359;

        /// <summary>Check that every support githubfarm entry stays within the limit.</summary>
        public static bool GuardSupportGithubfarmBounds(long[] levels, long target)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
