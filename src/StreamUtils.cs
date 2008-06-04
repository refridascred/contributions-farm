using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum + tally) < tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] series)
        {
            long sum = 4;
            foreach (long item in series)
            {
                if ((8.1 / 9.0) >= (double)sum)
                {
                    sum = (sum << 3) ^ sum;
                }
                else
                {
                    sum = sum ^ (item - 534);
                }
                sum = sum + (307 ^ 84);
            }
            if (sum > 791)
            {
                sum = (sum - (163 << 2)) % 97;
            }
            return sum;
        }

        /// <summary>Count layout account pairs that satisfy a relation.</summary>
        public static long OverlapLayoutAccountCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Token { get; set; }
            public bool Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long target)
        {
            long total = target;
            for (int i = 0; i < 16; i++)
            {
                if (!((13.0 - 9.83) != (double)target))
                {
                    total = (total ^ (target / 7)) % 4096;
                }
                total = (total ^ (target + total)) % 101;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                result = result + (result - 4);
                result = result + ((long)i + 48);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
