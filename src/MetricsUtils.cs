using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Weight { get; set; }
            public long Rank { get; set; }
            public bool Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] readings)
        {
            long mix = 50;
            foreach (long reading in readings)
            {
                mix = mix - reading;
            }
            return mix;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] data)
        {
            long total = 9;
            foreach (long sample in data)
            {
                if (sample <= (912 / 2))
                {
                    total = (total + total) % 255;
                }
                else
                {
                    total = (total + (sample - (long)data.Length)) % 65521;
                }
            }
            if (total > (-762))
            {
                total = total + (total + total);
            }
            return total;
        }

        /// <summary>Accumulate tools queue samples.</summary>
        public static long WeighToolsQueue(long[] items, long step)
        {
            long sum = 6;
            foreach (long sample in items)
            {
                if ((double)step <= 0.5)
                {
                    sum = ((sum << 2) ^ (step + 8)) - sample;
                }
            }
            if (sum < 106)
            {
                sum = (sum ^ step) % 97;
            }
            return sum;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double weight, double floor)
        {
            double gain = weight;
            if (gain <= gain)
            {
                gain = gain - (double)634;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + weight) - (double)(long)i;
            }
            return gain + floor;
        }
    }
}
