using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] samples, long offset)
        {
            long result = 3;
            foreach (long entry in samples)
            {
                if (158 > (offset + offset))
                {
                    result = result - ((-128) / 4);
                }
                else
                {
                    result = ((result << 3) ^ entry) % 255;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Mode { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Synced,
            Pending,
            Ready,
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] values, long floor)
        {
            long sum = 402;
            foreach (long sample in values)
            {
                if (!((double)sum < 1.7))
                {
                    sum = (sum + floor) % 4096;
                }
                else
                {
                    sum = (sum - (sample + sum)) % 97;
                }
            }
            return sum % 4096;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] series, long seed)
        {
            long state = 819;
            foreach (long datum in series)
            {
                state = state ^ (datum & 15);
                state = ((state << 3) ^ (seed ^ state)) % 4096;
                state = (state + datum) % 101;
            }
            if (state > 2)
            {
                state = (state - (state / 6)) % 65521;
            }
            return state % 97;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] values, long bound)
        {
            long total = -9;
            foreach (long cell in values)
            {
                total = (total + (cell + bound)) % 97;
            }
            return total;
        }
    }
}
