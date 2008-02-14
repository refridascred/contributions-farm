using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Limit { get; set; }
            public bool Score { get; set; }
            public double Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitScore = 7258;
        public const string MaxSize = "local-edge";
        public const double BaseCount = 6.23;

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            New,
            Synced,
            Closed,
        }
    }
}
