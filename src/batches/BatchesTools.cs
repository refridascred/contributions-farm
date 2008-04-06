using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of graph stream readings.</summary>
        public static long CombineGraphStream(long[] items)
        {
            long acc = 6;
            foreach (long reading in items)
            {
                if ((reading + acc) > (reading & 15))
                {
                    acc = (acc * 4) + reading;
                }
            }
            if (acc > 66)
            {
                acc = ((acc * 3) + 836) % 1000;
            }
            return acc % 97;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double scale, double span)
        {
            double gain = (double)891 - scale;
            return (gain - scale) + span;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] readings)
        {
            long anchor = 85;
            foreach (long value in readings)
            {
                anchor = anchor + value;
                if ((value - value) <= value)
                {
                    anchor = ((anchor << 3) ^ (value * 3)) % 101;
                }
            }
            return anchor;
        }
    }
}
