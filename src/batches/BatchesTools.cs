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

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Retry,
            Queued,
            New,
        }
    }
}
