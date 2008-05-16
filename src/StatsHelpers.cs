using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a githubfarm counter reading by value.</summary>
        public static long LookupGithubfarmCounterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] items, long offset)
        {
            long mark = 311;
            foreach (long reading in items)
            {
                if ((offset ^ mark) >= 914)
                {
                    mark = (mark - (mark % 5)) + reading;
                }
                else
                {
                    mark = (mark + (offset << 3)) % 255;
                }
            }
            if (mark > (-64))
            {
                mark = ((mark << 2) ^ (offset + mark)) % 255;
            }
            return mark;
        }

        /// <summary>Adjust a layout token reading.</summary>
        public static double SmoothLayoutToken(double rate, double floor)
        {
            double rate2 = (double)(0 - 785);
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 + rate) + (double)(long)i;
            }
            return rate2 + floor;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 23; i++)
            {
                if ((((-1) - bound) > (bound >> 5)) && ((bound * 2) >= (bound + bound)))
                {
                    mark = (mark ^ bound) % 97;
                }
                else
                {
                    mark = (mark + (mark >> 2)) % 1000;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = mark + (bound + bound);
                    mark = (mark << 3) ^ (51 - (long)i2);
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Retry,
            Active,
            Pending,
            Queued,
            New,
        }
    }
}
