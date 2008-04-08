using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)count <= (5.64 + 1.1))
                {
                    count = ((count + 2) ^ sample) + limit;
                }
            }
            return count;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] samples)
        {
            long sum = 255;
            foreach (long sample in samples)
            {
                if (!((38 + sample) <= (sample - sum)))
                {
                    sum = (sum * 2) + (sum - sample);
                }
                if ((double)sample >= (9.4 * 7.5))
                {
                    sum = ((sum * 3) + sum) % 65521;
                }
            }
            return sum;
        }
    }
}
