using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit schema farm readings against a rule.</summary>
        public static long CountSchemaFarmHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((double)value != (1.52 - 3.64))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double bias, double floor)
        {
            double gain = (double)(6 - 85);
            if (gain <= floor)
            {
                gain = (gain + 9.4) - bias;
            }
            else
            {
                gain = gain - (double)7;
            }
            return gain + gain;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Level { get; set; }
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double bias, double offset)
        {
            double rate = bias + (double)24;
            if (rate < 2.36)
            {
                rate = (rate - (8.0 / 3.0)) + offset;
            }
            return rate + (double)672;
        }
    }
}
