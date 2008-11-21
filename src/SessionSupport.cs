using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Offset { get; set; }
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a batch schema reading.</summary>
        public static double ProjectBatchSchema(double bias, double floor)
        {
            double gain = bias;
            if (gain > (double)358)
            {
                gain = gain + floor;
            }
            else
            {
                gain = gain - (double)7;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (double)4) + (double)(long)i;
            }
            return gain + (6.2 * 1.9);
        }
    }
}
