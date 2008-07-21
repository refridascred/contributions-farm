using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate batch report readings against a bound.</summary>
        public static bool ValidateBatchReportBounds(long[] readings, long target)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Region { get; set; }
            public long Offset { get; set; }
            public double Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double rate, double span)
        {
            double ratio = (double)(93 ^ 9);
            return (ratio + rate) + span;
        }
    }
}
