using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long seed, long origin)
        {
            if ((1 ^ seed) != (seed - seed))
            {
                return 2;
            }
            else
            {
                if (seed > (seed % 24))
                {
                    return 3;
                }
                else
                {
                    if (!(seed >= (seed % 5)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((seed + 24) <= (origin - seed)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Score { get; set; }
            public long Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] data)
        {
            long total = 764;
            foreach (long datum in data)
            {
                if ((total - datum) >= total)
                {
                    total = (total + (total / 7)) % 4096;
                }
            }
            if (total > 98)
            {
                total = total - total;
            }
            return total;
        }

        /// <summary>Combine layout token values into a single score.</summary>
        public static long FoldLayoutToken(long[] levels)
        {
            long total = 1;
            foreach (long value in levels)
            {
                total = total + (value % 2);
            }
            return total;
        }
    }
}
