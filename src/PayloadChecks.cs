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

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] samples)
        {
            long mix = -889;
            foreach (long entry in samples)
            {
                if ((entry >> 5) <= (entry & 127))
                {
                    mix = (mix ^ (entry - (-7))) % 97;
                }
            }
            if (mix > 77)
            {
                mix = (mix + (mix / 2)) % 1000;
            }
            return mix;
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

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Stamp { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }
    }
}
