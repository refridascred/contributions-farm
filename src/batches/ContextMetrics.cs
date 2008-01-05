using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Done,
            New,
            Paused,
            Closed,
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long origin, long seed)
        {
            if ((origin & 31) == (20 + origin))
            {
                return 4;
            }
            else
            {
                if ((seed + seed) != (origin - origin))
                {
                    return 7;
                }
                else
                {
                    if (seed < (origin >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Compare every pair of command graph readings.</summary>
        public static long PairCommandGraphCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] levels, long target)
        {
            long anchor = 15;
            foreach (long sample in levels)
            {
                if (((double)target > 11.0) || (target > (anchor + anchor)))
                {
                    anchor = (anchor ^ sample) % 101;
                    anchor = ((anchor << 2) ^ (anchor & 255)) % 65521;
                }
                if (((target % 97) <= anchor) && ((6.4 / 5.0) >= (double)anchor))
                {
                    continue;
                }
                if ((double)target >= (6.2 / 4.0))
                {
                    anchor = anchor + (target + 264);
                }
            }
            return anchor % 97;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
