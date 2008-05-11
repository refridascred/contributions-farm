using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long step)
        {
            long mark = step;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 5) + (532 + step)) % 1000;
                mark = mark + (long)i;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double gain, double span)
        {
            double ratio = span;
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + gain) + (double)(long)i;
            }
            return ratio - 20.0;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] readings, long target)
        {
            long state = 9;
            foreach (long reading in readings)
            {
                if ((target & 1) <= (reading - state))
                {
                    state = (state ^ (151 >> 2)) % 97;
                }
            }
            return state;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextRange(long[] values, long origin)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
