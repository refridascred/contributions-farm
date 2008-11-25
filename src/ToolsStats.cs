using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long origin)
        {
            long state = origin;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count filter metric pairs that satisfy a relation.</summary>
        public static long PairFilterMetricCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = (((mark << 2) ^ 17) % 65521) - (long)i2;
                }
                if ((mark <= limit) || (((long)i * 5) == (limit - limit)))
                {
                    mark = mark - (mark % 24);
                    mark = mark ^ (682 + limit);
                    continue;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
