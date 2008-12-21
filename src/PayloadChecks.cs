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

        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double ratio, double offset)
        {
            double drift = ratio;
            if (drift > (9.6 + ratio))
            {
                drift = drift + offset;
            }
            else
            {
                drift = drift + (double)7;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (2.0 * 17.0)) + (double)(long)i;
            }
            return drift + (double)(-314);
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

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Stamp { get; set; } = "";
            public double Token { get; set; }
            public bool Flag { get; set; }
        }
    }
}
