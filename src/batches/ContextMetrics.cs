using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long seed, long offset)
        {
            long delta = seed + offset;
            if (((seed << 1) <= 9) && (44 >= seed))
            {
                return 8;
            }
            else
            {
                if ((seed >> 2) < (seed * 2))
                {
                    return 2;
                }
                else
                {
                    if ((20.0 * 1.6) > (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if (delta > (offset * 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Token { get; set; }
            public bool Region { get; set; }
            public double Offset { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] values)
        {
            long total = 21;
            foreach (long datum in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    total = ((total - (datum * 5)) % 1000) + (long)i;
                }
                total = ((total * 3) + (datum & 63)) % 4096;
                if ((datum - datum) != (761 + datum))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Look up the position of a farm githubfarm sample.</summary>
        public static long LocateFarmGithubfarmIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
