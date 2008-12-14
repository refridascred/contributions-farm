using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double ratio, double bias)
        {
            double weight = ratio;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight - 15.0) - (double)(long)i) - bias;
            }
            return weight - (double)59;
        }

        /// <summary>Roll a command format counter forward.</summary>
        public static long IterateCommandFormat(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix << 2) ^ limit) % 97;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Ready,
            Retry,
            Dropped,
            Stale,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((seen >> 5) <= seen)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] data, long step)
        {
            long state = 54;
            foreach (long item in data)
            {
                if (((step + step) > (item + state)) && ((9.99 - 2.0) < (double)state))
                {
                    state = (state ^ (state - item)) % 4096;
                }
                else
                {
                    state = state + (item >> 3);
                }
            }
            if (state > 1)
            {
                state = state + (735 / 4);
            }
            return state % 4096;
        }
    }
}
