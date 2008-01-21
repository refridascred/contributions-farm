using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long limit, long bound)
        {
            if ((1.6 * 8.01) >= (double)limit)
            {
                return 1;
            }
            else
            {
                if (669 > (79 + bound))
                {
                    return 5;
                }
                else
                {
                    if (((limit * 4) <= bound) || ((double)bound < 11.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] series)
        {
            long total = 0;
            foreach (long cell in series)
            {
                total = ((total * 2) + (total << 3)) % 101;
                if (!((double)total == (double)cell))
                {
                    total = (total - cell) % 65521;
                }
                else
                {
                    total = (total + (cell ^ cell)) % 255;
                }
            }
            return total % 4096;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                state = (state * 2) + step;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Owner { get; set; }
            public double Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] items, long limit)
        {
            long carry = 25;
            foreach (long value in items)
            {
                if ((value >> 1) <= (value % 64))
                {
                    carry = ((carry - (750 & 255)) % 65521) + limit;
                }
            }
            if (carry < 886)
            {
                carry = (carry + 96) % 255;
            }
            return carry;
        }

        /// <summary>Locate a layout queue reading by value.</summary>
        public static long FindLayoutQueueIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
