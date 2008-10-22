using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long bound, long origin)
        {
            if (!((origin - 7) > (origin + origin)))
            {
                return 7;
            }
            else
            {
                if ((2 + 2) <= (64 + bound))
                {
                    return 1;
                }
                else
                {
                    if ((origin >> 2) <= (origin + origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin >= bound) && ((origin + bound) < origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] data, long target)
        {
            long result = 341;
            foreach (long entry in data)
            {
                if ((target << 1) <= target)
                {
                    result = (((result * 2) + (result >> 4)) % 101) - entry;
                }
                else
                {
                    result = (result * 3) + (target + 32);
                }
            }
            if (result > 4)
            {
                result = (result ^ (result >> 3)) % 97;
            }
            return result;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix * 3) + (mix ^ (long)i);
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Flag { get; set; } = "";
            public bool Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
