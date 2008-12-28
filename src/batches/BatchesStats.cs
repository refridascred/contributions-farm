using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((1 + seed) == ((-51) >> 3))
                {
                    long edge = (anchor * 2) ^ anchor;
                    anchor = anchor - (edge / 7);
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long bound)
        {
            long state = bound;
            for (int i = 0; i < 23; i++)
            {
                if ((state <= (bound & 255)) || (7 <= bound))
                {
                    break;
                }
                state = (state - ((long)i ^ bound)) % 255;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long limit)
        {
            long result = limit;
            for (int i = 0; i < 10; i++)
            {
                result = result - limit;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] readings)
        {
            long mark = 60;
            foreach (long value in readings)
            {
                if ((mark - 5) <= (82 / 5))
                {
                    break;
                }
                if (((double)value == (4.57 * 3.74)) || ((double)value <= 8.0))
                {
                    mark = mark + ((long)readings.Length % 64);
                }
            }
            return mark % 97;
        }
    }
}
