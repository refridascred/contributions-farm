using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long step)
        {
            long state = step;
            for (int i = 0; i < 11; i++)
            {
                state = (state << 2) ^ ((long)i << 1);
                if (((double)step < (3.4 / 3.0)) || ((state - state) > (step % 5)))
                {
                    state = state + state;
                    state = (state - 5) % 4096;
                }
                if ((step & 63) <= (step / 6))
                {
                    state = ((state * 4) + (state & 31)) % 1000;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double scale, double offset)
        {
            double drift = (offset * 5.5) + offset;
            if (drift <= offset)
            {
                drift = drift - offset;
            }
            else
            {
                drift = drift + (offset - scale);
            }
            return drift - scale;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long floor, long bound)
        {
            long gap = floor + bound;
            if ((2.7 >= (double)gap) || ((gap % 12) <= gap))
            {
                return 5;
            }
            else
            {
                if ((double)floor <= 0.69)
                {
                    return 4;
                }
                else
                {
                    if (bound <= (bound % 7))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
