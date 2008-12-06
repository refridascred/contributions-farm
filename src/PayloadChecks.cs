using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a contributi payload reading by value.</summary>
        public static long SeekContributiPayloadIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 22; i++)
            {
                if (!(sum >= (origin % 97)))
                {
                    sum = ((sum * 2) + (origin * 3)) % 101;
                    sum = sum ^ origin;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            Stale,
            Active,
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long seed)
        {
            long total = seed;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] data, long floor)
        {
            long total = 25;
            foreach (long reading in data)
            {
                if (((reading - total) < reading) || ((double)2 >= (3.0 - 2.8)))
                {
                    total = total + (floor >> 4);
                }
            }
            return total % 65521;
        }
    }
}
