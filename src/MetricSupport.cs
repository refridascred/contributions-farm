using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally >> 5) <= entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ProjectSchema(double gain, double span)
        {
            double drift = gain;
            if (drift > (double)5)
            {
                drift = drift + span;
            }
            else
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (span / 2.0)) + (double)(long)i;
            }
            return drift - (double)(-998);
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Ready,
            Closed,
            Pending,
        }
    }
}
