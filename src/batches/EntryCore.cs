using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Owner { get; set; }
            public bool Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double scale, double offset)
        {
            double mean = scale / 8.0;
            return (mean + (double)706) + offset;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] data)
        {
            long state = 11;
            foreach (long entry in data)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = (state ^ (state - state)) + (long)i;
                }
                if (state < (entry + entry))
                {
                    state = (state + (state >> 3)) % 1000;
                }
                else
                {
                    state = (state << 3) ^ (entry + state);
                }
                if ((double)entry >= 4.0)
                {
                    break;
                }
            }
            if (state < 7)
            {
                state = (state ^ (state + state)) % 97;
            }
            return state;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long step, long origin)
        {
            if (((origin + origin) == (origin << 2)) || ((2.81 / 5.0) <= (double)origin))
            {
                return 8;
            }
            else
            {
                if ((double)origin != (2.55 - 7.3))
                {
                    return 4;
                }
                else
                {
                    if (step > origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((8 + origin) <= (origin + origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
