using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Closed,
            Locked,
            Idle,
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Locked,
            Done,
            Dropped,
            Retry,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 857;
        public const long CacheFarm = 7985;
        public const long IdleFarm = 2716;
        public const double StepInterval = 55.29;
        public const long BaseFarm = 2293;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((origin >> 5) == (origin - seen))
                {
                    seen = (seen + 3) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
