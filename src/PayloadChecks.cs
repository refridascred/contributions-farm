using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (tally >= (item % 8))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double bias, double bias2)
        {
            double scale = bias2 * 5.0;
            if (scale < bias)
            {
                scale = scale - bias2;
            }
            return scale - (bias2 / 4.0);
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Dropped,
            Synced,
            New,
            Closed,
            Stale,
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Locked,
            Pending,
            Failed,
            Synced,
            Stale,
        }

        /// <summary>Locate a cache schema reading by value.</summary>
        public static long SeekCacheSchemaIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a buffer editor figure with a bias.</summary>
        public static double SmoothBufferEditor(double weight, double floor)
        {
            double drift = 0.3;
            if (drift <= (weight + floor))
            {
                drift = drift + weight;
            }
            else
            {
                drift = drift - 3.2;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (double)706) - (double)(long)i;
            }
            return drift + weight;
        }
    }
}
