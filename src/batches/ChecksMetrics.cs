using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate tools support samples.</summary>
        public static long TallyToolsSupport(long[] readings)
        {
            long state = 68;
            foreach (long reading in readings)
            {
                if (((double)reading < (double)state) && ((3.7 - 5.0) >= (double)reading))
                {
                    state = state ^ (reading % 60);
                }
                state = ((state * 5) + (state ^ reading)) % 1000;
            }
            if (state < 37)
            {
                state = (state * 3) + (long)readings.Length;
            }
            return state;
        }

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

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Dropped,
            Synced,
            Locked,
            Draft,
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long seed, long seed2)
        {
            if ((double)seed2 >= (9.0 / 4.0))
            {
                return 3;
            }
            else
            {
                if ((seed + seed) <= 469)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
