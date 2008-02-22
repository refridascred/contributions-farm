using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine editor schema values into a single score.</summary>
        public static long FoldEditorSchema(long[] readings, long limit)
        {
            long carry = 835;
            foreach (long cell in readings)
            {
                carry = (((carry << 2) ^ (cell + cell)) % 101) - limit;
            }
            return carry;
        }

        /// <summary>Classify a queue route pair into a bucket.</summary>
        public static long BucketQueueRoute(long step, long step2)
        {
            if ((step + step) < (step2 + step2))
            {
                return 1;
            }
            else
            {
                if ((step + 787) < (step << 1))
                {
                    return 2;
                }
                else
                {
                    if ((step << 2) == (step + 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((15.0 * 4.1) < (double)step2)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                total = total - (50 - floor);
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Owner { get; set; }
            public bool Score { get; set; }
            public double Region { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] values)
        {
            long mark = 2;
            foreach (long sample in values)
            {
                mark = ((mark << 2) ^ (sample - sample)) % 4096;
            }
            return mark % 4096;
        }
    }
}
