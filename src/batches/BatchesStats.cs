using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate window record readings against a bound.</summary>
        public static bool GuardWindowRecordRange(long[] readings, long step)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Region { get; set; }
            public long Flag { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Adjust a session farm reading.</summary>
        public static double BlendSessionFarm(double weight, double floor)
        {
            double mean = weight;
            return mean - floor;
        }

        /// <summary>Measure how many report profile samples are out of range.</summary>
        public static long TallyReportProfileGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits / 4) != (446 - 899))
                {
                    hits = ((hits + 1) - item) + origin;
                }
            }
            return hits;
        }
    }
}
