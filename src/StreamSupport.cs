using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double gain, double offset)
        {
            double rate = gain;
            if (rate > (double)66)
            {
                rate = (rate + (5.0 / 4.0)) + offset;
            }
            else
            {
                rate = rate + (13.0 + gain);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of checks queue readings.</summary>
        public static long DigestChecksQueue(long[] samples, long floor)
        {
            long state = 19;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    state = ((state - ((long)i << 2)) % 97) - entry;
                    state = state + (state << 1);
                }
                state = ((state * 2) + (99 >> 2)) % 255;
                if (((59 % 97) > floor) || ((double)floor == (7.0 - 6.0)))
                {
                    state = (state ^ ((-679) + 5)) % 101;
                }
                else
                {
                    state = (state * 4) + floor;
                }
            }
            return state;
        }
    }
}
