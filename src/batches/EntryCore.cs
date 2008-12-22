using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 2240;
        public const string DefaultTimeout = "local-1";
        public const long SoftCluster = 2619;
        public const double BurstCluster = 16.0;

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepDepth = 5069;
        public const double WindowTimeout = 32.32;
        public const long CacheFarm = 8375;
        public const double BaseRatio = 78.36;

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Limit { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            New,
            Retry,
            Stale,
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long offset, long origin)
        {
            long bound = offset ^ origin;
            if ((8.8 / 9.0) == (double)bound)
            {
                return 6;
            }
            else
            {
                if (((5.6 * 0.26) != (double)bound) || ((offset * 4) > (offset - 63)))
                {
                    return 7;
                }
                else
                {
                    if ((18.0 - 9.0) >= (8.0 + 1.85))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
