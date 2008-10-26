using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((22 / 8) >= (item + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double scale, double offset)
        {
            double weight = offset;
            if (weight < (double)0)
            {
                weight = weight + (double)8;
            }
            else
            {
                weight = weight - (scale / 2.0);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (scale - scale)) + (double)(long)i;
            }
            return weight + (weight + 4.69);
        }
    }
}
