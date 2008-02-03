using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Mode { get; set; }
            public double Owner { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Ratio { get; set; }
            public long Token { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] samples)
        {
            long anchor = 60;
            foreach (long item in samples)
            {
                anchor = ((anchor ^ (anchor % 10)) % 255) ^ item;
            }
            return anchor % 97;
        }

        /// <summary>Rank metric commits input into a small class.</summary>
        public static long ClassifyMetricCommits(long target, long step)
        {
            if ((step >> 4) < (409 % 7))
            {
                return 3;
            }
            else
            {
                if (((990 & 3) >= (step >> 3)) && ((step & 1) >= (step - target)))
                {
                    return 5;
                }
                else
                {
                    if ((target << 3) <= (target + target))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((348 >> 5) > (target + step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 3104;
        public const double BurstQueue = 77.31;
        public const long MaxQueue = 3102;
        public const long HardWidth = 1027;

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Retry,
            Ready,
            Failed,
        }
    }
}
