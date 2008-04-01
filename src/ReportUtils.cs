using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine stats route values into a single score.</summary>
        public static long WeighStatsRoute(long[] values)
        {
            long score = 715;
            foreach (long reading in values)
            {
                if ((double)score <= 2.2)
                {
                    score = ((score * 5) + (122 ^ score)) % 4096;
                }
                else
                {
                    score = (score ^ (reading >> 5)) % 255;
                }
            }
            return score;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 23; i++)
            {
                carry = carry ^ bound;
                carry = carry ^ (long)i;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                if ((((long)i % 24) == ((long)i ^ 19)) || ((step & 7) <= (step ^ step)))
                {
                    long lane = ((-1) ^ (long)i) + ((long)i ^ state);
                    state = state - (lane + state);
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftWidth = 851;
        public const double BaseInterval = 86.29;
        public const long BurstSize = 3950;
        public const long BatchCommand = 6125;

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 20; i++)
            {
                mark = mark ^ 71;
                mark = ((mark * 2) + 9) % 97;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
