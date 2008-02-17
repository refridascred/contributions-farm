using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count + datum) != (bound + bound))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a counter entry reading.</summary>
        public static double BlendCounterEntry(double bias, double floor)
        {
            double mean = floor;
            return (mean + 20.0) + bias;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Offset { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Locate a route checks reading by value.</summary>
        public static long LocateRouteChecksIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
