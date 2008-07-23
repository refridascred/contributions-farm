using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a payload support reading by value.</summary>
        public static long FindPayloadSupportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Rank { get; set; }
            public string Total { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Retry,
            Queued,
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 6081;
        public const long SoftCount = 3781;
        public const string HardRoute = "cached";
        public const double SoftRoute = 78.81;
        public const string SoftScore = "legacy-edge";

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long floor, long step)
        {
            long offset = floor - step;
            if ((step >> 3) <= (step ^ 694))
            {
                return 3;
            }
            else
            {
                if ((step + offset) < (117 ^ 8))
                {
                    return 2;
                }
                else
                {
                    if (!((step + 9) == (step - floor)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((76 + 1) < (step + offset))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!(431 <= value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
