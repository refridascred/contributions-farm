using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit commits cluster readings against a rule.</summary>
        public static long CountCommitsClusterGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen & 7) != (seen & 15))
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Classify a record counter pair into a bucket.</summary>
        public static long GradeRecordCounter(long origin, long bound)
        {
            if ((17.0 * 8.0) < (double)bound)
            {
                return 1;
            }
            else
            {
                if ((19.0 + 10.0) < (double)bound)
                {
                    return 8;
                }
                else
                {
                    if ((double)bound >= (double)origin)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Count { get; set; }
            public bool Flag { get; set; }
            public double Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BurstCache = "primary-edge";
        public const string LimitTimeout = "primary-edge";
        public const string IdleCache = "legacy-1";

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 6640;
        public const long SoftStream = 7795;
        public const long BaseStream = 4695;
    }
}
