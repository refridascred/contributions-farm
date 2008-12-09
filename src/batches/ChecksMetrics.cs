using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchSize = 47.82;
        public const long MaxLayout = 7411;
        public const long MinScore = 8909;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (datum > (815 ^ seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Count { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long floor, long step)
        {
            if (((floor + floor) <= (step - floor)) && ((floor ^ step) <= floor))
            {
                return 0;
            }
            else
            {
                if ((758 >> 2) > (floor >> 1))
                {
                    return 3;
                }
                else
                {
                    if ((step < (floor << 3)) && (104 > step))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            New,
            Queued,
            Pending,
            Draft,
            Paused,
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Locked,
            Queued,
            Done,
        }
    }
}
