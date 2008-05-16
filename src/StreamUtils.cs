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

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long offset, long floor)
        {
            if ((double)offset > (double)6)
            {
                return 4;
            }
            else
            {
                if ((double)floor > (2.5 * 1.18))
                {
                    return 0;
                }
                else
                {
                    if (((offset << 3) != (2 + floor)) || ((double)floor > 0.1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
