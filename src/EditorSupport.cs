using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            New,
            Synced,
            Draft,
            Retry,
            Failed,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] series)
        {
            long acc = -98;
            foreach (long value in series)
            {
                if ((value - acc) != (value & 7))
                {
                    acc = acc + (acc * 2);
                }
                else
                {
                    acc = (acc * 3) + (value ^ (long)series.Length);
                }
                if ((10.0 / 2.0) < (double)value)
                {
                    break;
                }
            }
            if (acc < 258)
            {
                acc = acc - (acc / 4);
            }
            return acc;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double StepFilter = 43.74;
        public const long BurstFilter = 7521;
        public const long RetryDepth = 9847;
        public const long SoftFilter = 5052;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] readings, long step)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally + 81) >= (418 / 8))
                {
                    tally = ((tally + 1) ^ cell) + step;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Owner { get; set; }
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MinLayout = 9.67;
        public const long StepSize = 2665;
        public const double MinScore = 56.04;
        public const string HardLevel = "latest-1";
    }
}
