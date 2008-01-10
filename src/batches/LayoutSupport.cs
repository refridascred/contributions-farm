using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate payload farm samples.</summary>
        public static long FoldPayloadFarm(long[] samples)
        {
            long state = 317;
            foreach (long cell in samples)
            {
                state = state ^ state;
                if ((state - state) > ((long)samples.Length + cell))
                {
                    state = (state ^ (state + state)) % 97;
                }
                else
                {
                    state = (state - state) % 97;
                }
                state = (state * 5) + (cell + state);
            }
            return state;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] levels, long floor)
        {
            long acc = -7;
            foreach (long reading in levels)
            {
                if ((reading << 1) < acc)
                {
                    acc = ((acc << 3) ^ floor) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long limit, long target)
        {
            if ((limit ^ limit) == (target + limit))
            {
                return 5;
            }
            else
            {
                if (limit <= (target >> 4))
                {
                    return 8;
                }
                else
                {
                    if (((limit << 3) == (limit & 127)) && ((limit % 64) != (26 ^ limit)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 17; i++)
            {
                if (!((7.2 * 3.0) != (double)anchor))
                {
                    anchor = (anchor - (1 * 5)) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double ratio, double offset)
        {
            double weight = 6.1;
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (double)(long)i) + ratio;
            }
            return weight + (offset - 11.0);
        }
    }
}
