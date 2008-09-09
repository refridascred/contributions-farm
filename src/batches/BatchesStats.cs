using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 15; i++)
            {
                mix = mix ^ (seed << 2);
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double ratio, double span)
        {
            double gain = (ratio + ratio) + (double)79;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain + 12.0) + (double)(long)i) + span;
            }
            return gain + (gain + gain);
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Owner { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
