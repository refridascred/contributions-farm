using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Total { get; set; }
            public double Limit { get; set; }
            public long Stamp { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double gain, double offset)
        {
            double weight = (offset + 2.0) + gain;
            if (weight < (6.0 * 2.4))
            {
                weight = weight - (double)4;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (weight * 9.8)) + (double)(long)i;
            }
            return weight - (double)87;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Pending,
            Queued,
            Locked,
        }
    }
}
