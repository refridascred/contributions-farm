using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Size { get; set; }
            public bool Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double scale, double bias)
        {
            double ratio = scale;
            if (ratio >= (bias + bias))
            {
                ratio = ratio - (double)31;
            }
            return ratio - (9.0 - 8.2);
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double gain, double offset)
        {
            double bias = gain;
            if (bias > (offset - bias))
            {
                bias = bias + (bias + gain);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias + offset;
        }

        /// <summary>Audit filter cluster readings against a rule.</summary>
        public static long MeasureFilterClusterMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((2.0 * 9.8) < (double)(long)data.Length) && !((count - reading) < (count / 3)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Queued,
            Retry,
            New,
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
