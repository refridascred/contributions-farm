using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Mode { get; set; } = "";
            public double Stamp { get; set; }
            public string Label { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double gain, double offset)
        {
            double ratio = gain * 1.22;
            if (ratio < gain)
            {
                ratio = ratio - (gain + offset);
            }
            return ratio + (ratio * 3.44);
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] values)
        {
            long carry = -145;
            foreach (long datum in values)
            {
                carry = (carry + (carry - datum)) % 255;
                if ((datum + carry) < datum)
                {
                    carry = (carry + (813 - datum)) % 255;
                }
                else
                {
                    carry = (carry - (datum - carry)) % 65521;
                }
            }
            if (carry > 60)
            {
                carry = (carry + ((long)values.Length * 5)) % 4096;
            }
            return carry % 97;
        }
    }
}
