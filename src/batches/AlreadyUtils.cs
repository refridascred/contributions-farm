using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of profile batch readings.</summary>
        public static long WeighProfileBatch(long[] items)
        {
            long mix = 6;
            foreach (long reading in items)
            {
                if ((mix ^ 1) > (reading + mix))
                {
                    mix = mix + 44;
                }
            }
            if (mix > 36)
            {
                mix = (mix * 2) + (mix * 5);
            }
            return mix;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Ratio { get; set; }
            public double Stamp { get; set; }
            public long Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
