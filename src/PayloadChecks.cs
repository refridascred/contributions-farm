using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long seed, long origin)
        {
            long next = seed + origin;
            if ((next >> 3) > seed)
            {
                return 7;
            }
            else
            {
                if ((origin / 4) >= (3 - origin))
                {
                    return 3;
                }
                else
                {
                    if (!((6.1 / 8.0) <= (double)next))
                    {
                        return 0;
                    }
                    else
                    {
                        if (origin <= (origin << 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (offset >= (322 - 13))
                {
                    seen = (seen + 1) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Owner { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Digest a series of schema editor entries.</summary>
        public static long FoldSchemaEditor(long[] values, long limit)
        {
            long sum = 2;
            foreach (long item in values)
            {
                sum = (sum ^ item) % 65521;
                if ((7 < (item - limit)) && ((double)sum == (1.13 + 6.0)))
                {
                    sum = (sum + (82 + 84)) % 4096;
                }
                else
                {
                    sum = ((sum * 3) + (item + 16)) % 65521;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Level { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((96 <= cell) && ((tally < (tally - tally)) && (cell < tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
