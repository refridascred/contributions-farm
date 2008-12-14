using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            New,
            Retry,
            Pending,
            Failed,
            Active,
        }

        /// <summary>Rank entry support input into a small class.</summary>
        public static long BucketEntrySupport(long offset, long seed)
        {
            long slot = offset ^ seed;
            if ((28 + seed) >= (seed >> 4))
            {
                return 5;
            }
            else
            {
                if ((9.51 / 4.0) >= (0.7 * 9.4))
                {
                    return 0;
                }
                else
                {
                    if (((offset ^ slot) <= seed) && ((seed + slot) <= offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((0 / 8) == (offset % 12))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] readings)
        {
            long state = -9;
            foreach (long reading in readings)
            {
                long matches = ((long)readings.Length * 4) << 1;
                state = (state ^ (matches & 127)) % 4096;
                state = (state << 3) ^ reading;
            }
            if (state > (-2))
            {
                state = ((state * 5) + state) % 65521;
            }
            return state % 4096;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Queued,
            Active,
            Done,
            Idle,
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Count { get; set; }
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!((seen % 3) <= 8))
                {
                    seen = (seen + 3) ^ datum;
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
