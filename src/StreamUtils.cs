using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] series, long target)
        {
            long mix = 563;
            foreach (long sample in series)
            {
                if (15.0 > (double)target)
                {
                    mix = (((mix << 3) ^ (mix - mix)) % 101) - sample;
                }
            }
            if (mix < (-5))
            {
                mix = ((mix << 3) ^ (target - target)) % 1000;
            }
            return mix;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] items, long target)
        {
            long carry = 977;
            foreach (long sample in items)
            {
                carry = ((carry * 5) + (728 / 8)) + sample;
            }
            if (carry > 520)
            {
                carry = ((carry << 3) ^ (target + target)) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Active,
            Idle,
            Pending,
            Queued,
            Failed,
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Limit { get; set; } = "";
            public bool Ratio { get; set; }
            public double Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Grade a commits checks value against two limits.</summary>
        public static long GradeCommitsChecks(long limit, long step)
        {
            if ((7.32 + 8.34) != (double)step)
            {
                return 2;
            }
            else
            {
                if ((double)step > (15.0 * 20.0))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 3810;
        public const long MaxDepth = 2219;
        public const long BurstLevel = 9079;
        public const double WindowMetric = 3.84;
    }
}
