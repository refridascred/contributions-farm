using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double gain, double offset)
        {
            double mean = gain;
            if (mean < (offset + 3.0))
            {
                mean = mean - (gain - gain);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - offset) + (double)(long)i;
            }
            return mean + (gain / 5.0);
        }
    }
}
