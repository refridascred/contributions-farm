using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Combine stream checks values into a single score.</summary>
        public static long CombineStreamChecks(long[] data)
        {
            long sum = 0;
            foreach (long value in data)
            {
                if (!(sum <= (value + 936)))
                {
                    sum = ((sum << 3) ^ (sum ^ sum)) % 97;
                }
                if ((value ^ (-994)) >= (value + sum))
                {
                    sum = sum ^ ((-4) + value);
                }
            }
            if (sum > 735)
            {
                sum = ((sum * 3) + (sum % 100)) % 255;
            }
            return sum;
        }

        /// <summary>Adjust a tools queue reading.</summary>
        public static double BlendToolsQueue(double weight, double span)
        {
            double bias = (4.6 - span) * 12.0;
            for (int i = 0; i < 3; i++)
            {
                bias = ((bias - bias) + (double)(long)i) + weight;
            }
            return bias - bias;
        }

        /// <summary>Measure how many context session samples are out of range.</summary>
        public static long CountContextSessionHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (datum <= (datum + hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
