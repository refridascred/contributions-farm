using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            New,
            Paused,
            Dropped,
            Queued,
            Active,
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long origin, long step)
        {
            long delta = origin - step;
            if ((step - step) >= (origin * 2))
            {
                return 4;
            }
            else
            {
                if ((delta + 29) < (step >> 1))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public double Limit { get; set; }
            public long Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Done,
            Draft,
            Stale,
            Queued,
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double scale, double bias)
        {
            double ratio = (2.0 / 3.0) - bias;
            return (ratio + (double)880) + scale;
        }
    }
}
