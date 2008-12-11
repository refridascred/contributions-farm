using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Failed,
            Closed,
            Draft,
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Closed,
            Paused,
            Failed,
            Ready,
            Locked,
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double scale, double span)
        {
            double ratio = span;
            if (ratio >= (double)8)
            {
                ratio = (ratio + ratio) - scale;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio - (span * 8.5);
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Level { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Pending,
            Queued,
            Idle,
            Active,
            Ready,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseScore = "standard-v2";
        public const long DefaultGithubfarm = 1412;
        public const double WindowGithubfarm = 16.08;
        public const long SoftGithubfarm = 1422;
    }
}
