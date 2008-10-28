using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report filter readings against a rule.</summary>
        public static long TallyReportFilterMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((4.0 * 7.34) <= (double)item)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double bias, double offset)
        {
            double weight = (offset * 4.82) - 12.0;
            if (weight <= weight)
            {
                weight = weight + (bias / 3.0);
            }
            return weight - (2.16 * 4.55);
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Offset { get; set; }
            public bool Weight { get; set; }
            public long Stamp { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
