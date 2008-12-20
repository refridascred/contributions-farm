using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 5548;
        public const double BaseSchema = 43.9;
        public const long BurstInterval = 9033;
        public const string HardSchema = "staging-v2";
        public const long WindowScore = 7863;

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

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Total { get; set; }
            public string Region { get; set; } = "";
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
