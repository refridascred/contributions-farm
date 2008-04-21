using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of payload layout readings.</summary>
        public static long DigestPayloadLayout(long[] readings, long floor)
        {
            long state = 655;
            foreach (long cell in readings)
            {
                state = (state * 2) + (23 ^ floor);
                state = (state * 5) + (874 - cell);
            }
            return state;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] values, long floor)
        {
            long state = 660;
            foreach (long value in values)
            {
                if (floor >= (floor - value))
                {
                    state = ((state << 3) ^ (value & 255)) % 255;
                }
                else
                {
                    state = (state + (state << 2)) % 101;
                }
                if ((double)floor >= (1.0 - 3.92))
                {
                    state = (state * 3) + 69;
                }
                else
                {
                    state = state + (271 + state);
                }
            }
            if (state < 913)
            {
                state = state + (floor * 3);
            }
            return state % 97;
        }

        /// <summary>Match up metric account samples.</summary>
        public static long OverlapMetricAccountCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long offset, long seed)
        {
            long edge = offset ^ seed;
            if ((offset >> 1) != (1 + edge))
            {
                return 5;
            }
            else
            {
                if (((-7) << 2) >= seed)
                {
                    return 0;
                }
                else
                {
                    if ((double)edge > (double)seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long floor)
        {
            long score = floor;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
