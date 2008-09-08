using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits < (hits ^ hits)) || ((hits ^ (long)data.Length) <= hits))
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] samples, long limit)
        {
            long result = 35;
            foreach (long value in samples)
            {
                result = result ^ (limit << 3);
                if (!((limit ^ result) != ((long)samples.Length ^ limit)))
                {
                    result = (result * 2) + (value - result);
                }
            }
            if (result < 1)
            {
                result = (result + (result / 5)) % 65521;
            }
            return result % 97;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public double Score { get; set; }
            public bool Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((8.3 + 6.36) >= (double)floor)
                {
                    break;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
