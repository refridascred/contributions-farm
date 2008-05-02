using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double ratio, double span)
        {
            double load = 6.7;
            if (load < (ratio - ratio))
            {
                load = load - (ratio * 8.0);
            }
            else
            {
                load = load + span;
            }
            return load - 10.0;
        }

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
