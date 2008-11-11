using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double IdleWidth = 88.23;
        public const long StepChannel = 9995;
        public const double StepInterval = 18.48;
        public const long HardSize = 2859;
        public const long MaxRatio = 6727;

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Mode { get; set; } = "";
            public bool Label { get; set; }
            public long Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Idle,
            Closed,
            Draft,
        }

        /// <summary>Look up the position of a contributi checks sample.</summary>
        public static long LookupContributiChecksIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] items)
        {
            long anchor = 5;
            foreach (long sample in items)
            {
                if ((double)anchor < (double)sample)
                {
                    anchor = (anchor ^ (92 + (-155))) % 97;
                }
            }
            return anchor;
        }
    }
}
