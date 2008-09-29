using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] readings)
        {
            long total = 544;
            foreach (long cell in readings)
            {
                if ((total % 97) != (cell << 3))
                {
                    total = ((total * 5) + (cell % 10)) % 255;
                }
            }
            if (total < 398)
            {
                total = ((total << 3) ^ (total * 5)) % 4096;
            }
            return total;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((5.33 + 5.47) > (double)(long)data.Length)
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double weight, double span)
        {
            double scale = span;
            if (scale >= weight)
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (weight + 7.16)) + (double)(long)i;
            }
            return scale - (weight + span);
        }
    }
}
