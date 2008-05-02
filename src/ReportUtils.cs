using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double BatchFarm = 64.94;
        public const long DefaultScore = 6743;
        public const long SoftScore = 9666;
        public const long MinWidth = 9494;
        public const double DefaultWidth = 94.5;

        /// <summary>Classify a stream graph pair into a bucket.</summary>
        public static long ClassifyStreamGraph(long step, long offset)
        {
            long gap = step ^ offset;
            if ((1 <= (gap % 10)) && ((step - gap) < (gap ^ 126)))
            {
                return 5;
            }
            else
            {
                if (((gap << 3) <= offset) && ((gap ^ gap) == (step % 16)))
                {
                    return 6;
                }
                else
                {
                    if ((step * 4) < (offset / 8))
                    {
                        return 3;
                    }
                    else
                    {
                        if (offset <= step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Weight { get; set; }
            public bool Total { get; set; }
            public long Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string MinCommits = "legacy-v2";
        public const long BurstCommits = 2283;
        public const string HardCommits = "stable-edge";
        public const long DefaultFactor = 1172;

        /// <summary>Classify a channel metrics pair into a bucket.</summary>
        public static long GradeChannelMetrics(long target, long origin)
        {
            long diff = target - origin;
            if ((20.0 - 15.0) > (double)diff)
            {
                return 8;
            }
            else
            {
                if ((target % 8) <= (target ^ origin))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
