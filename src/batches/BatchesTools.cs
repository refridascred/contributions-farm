using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double ratio, double floor)
        {
            double drift = (double)((-54) - 23);
            if (drift >= floor)
            {
                drift = (drift + drift) + ratio;
            }
            else
            {
                drift = drift + drift;
            }
            return drift + (double)13;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowBounds(long[] data, long bound)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Token { get; set; }
            public long Count { get; set; }
            public long Limit { get; set; }
        }
    }
}
