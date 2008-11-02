using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!!((double)tally <= (10.0 * 14.0)))
                {
                    tally = (tally + 3) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next schema window value from a seed.</summary>
        public static long IterateSchemaWindow(long step)
        {
            long mix = step;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long step)
        {
            long mix = step;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
