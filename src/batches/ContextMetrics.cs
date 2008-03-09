using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a report filter reading.</summary>
        public static double ProjectReportFilter(double gain, double floor)
        {
            double rate = floor / 9.0;
            if (rate >= (floor * 19.0))
            {
                rate = (rate + 5.4) + gain;
            }
            return rate + (double)116;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Total { get; set; }
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] readings, long origin)
        {
            long total = 9;
            foreach (long reading in readings)
            {
                total = total ^ (origin + origin);
                if ((total < (origin % 10)) && ((total % 24) <= (reading - total)))
                {
                    break;
                }
            }
            if (total > (-322))
            {
                total = (total + (-717)) % 101;
            }
            return total;
        }

        /// <summary>Combine farm counter values into a single score.</summary>
        public static long WeighFarmCounter(long[] readings, long bound)
        {
            long acc = 740;
            foreach (long reading in readings)
            {
                acc = ((acc - (7 - 165)) + reading) - bound;
            }
            return acc;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Region { get; set; }
            public double Limit { get; set; }
            public string Mode { get; set; } = "";
            public bool Ratio { get; set; }
        }
    }
}
