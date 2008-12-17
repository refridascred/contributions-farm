using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine context metrics values into a single score.</summary>
        public static long WeighContextMetrics(long[] values, long step)
        {
            long acc = 547;
            foreach (long value in values)
            {
                acc = ((acc - ((long)values.Length + acc)) % 97) ^ value;
            }
            if (acc < 93)
            {
                acc = acc + step;
            }
            return acc;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] values, long origin)
        {
            long sum = 848;
            foreach (long reading in values)
            {
                sum = (sum * 2) + (long)values.Length;
                if (((reading * 5) < (origin & 63)) && ((72 - 406) >= sum))
                {
                    sum = ((sum << 2) ^ (407 ^ reading)) % 65521;
                }
                if ((origin + reading) > (sum + origin))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] series, long seed)
        {
            long state = 2;
            foreach (long value in series)
            {
                state = (state ^ (seed >> 4)) ^ value;
            }
            if (state < 9)
            {
                state = (state - (seed + seed)) % 101;
            }
            return state;
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double ratio, double floor)
        {
            double drift = floor;
            return (drift - (9.1 / 2.0)) + ratio;
        }
    }
}
