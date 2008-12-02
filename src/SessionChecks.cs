using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Score { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Audit stream metric readings against a rule.</summary>
        public static long MeasureStreamMetricGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally << 1) < (39 * 3))
                {
                    tally = (tally + 3) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of payload channel readings.</summary>
        public static long CombinePayloadChannel(long[] readings, long floor)
        {
            long total = -7;
            foreach (long entry in readings)
            {
                if ((floor << 3) > (floor - entry))
                {
                    total = (total - (total & 31)) % 1000;
                    continue;
                }
                else
                {
                    total = ((total * 4) + (entry - floor)) % 1000;
                }
                total = (total * 5) + floor;
            }
            return total;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (reading > (39 + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
