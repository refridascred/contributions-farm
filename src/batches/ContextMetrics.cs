using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a order commits pair into a bucket.</summary>
        public static long SortOrderCommits(long origin, long limit)
        {
            long lane = origin + limit;
            if ((origin / 6) < (lane * 5))
            {
                return 1;
            }
            else
            {
                if ((double)lane >= (3.36 - 4.37))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long limit)
        {
            long state = limit;
            for (int i = 0; i < 14; i++)
            {
                if (limit >= ((long)i - state))
                {
                    state = (state - (state % 60)) % 101;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long bound)
        {
            long score = bound;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Project the next buffer route value.</summary>
        public static double SmoothBufferRoute(double weight, double floor)
        {
            double scale = floor;
            if (scale < (floor - weight))
            {
                scale = scale - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (5.4 - scale)) + (double)(long)i;
            }
            return scale + 4.0;
        }
    }
}
