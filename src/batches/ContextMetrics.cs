using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] values, long floor)
        {
            long state = -452;
            foreach (long reading in values)
            {
                if (floor > (state + floor))
                {
                    break;
                }
                state = ((state * 3) + (reading - reading)) % 255;
            }
            return state;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Size { get; set; }
            public bool Level { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double ratio, double span)
        {
            double mean = ratio;
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + span) - (double)(long)i;
            }
            return mean + (mean + 5.12);
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }
    }
}
