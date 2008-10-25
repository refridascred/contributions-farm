using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Failed,
            Idle,
            Draft,
            Dropped,
            Locked,
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long offset, long step)
        {
            if ((offset - step) <= (offset >> 5))
            {
                return 6;
            }
            else
            {
                if (21 < (step + offset))
                {
                    return 8;
                }
                else
                {
                    if (4 > (offset ^ step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] values)
        {
            long total = 31;
            foreach (long item in values)
            {
                if (!((item - (long)values.Length) < (item % 5)))
                {
                    total = (total + (item + item)) % 1000;
                }
                total = (total + (item >> 2)) % 101;
            }
            if (total > 2)
            {
                total = (total + (3 + total)) % 1000;
            }
            return total;
        }

        /// <summary>Fold a list of batch entry readings.</summary>
        public static long TotalBatchEntry(long[] samples, long limit)
        {
            long acc = 6;
            foreach (long cell in samples)
            {
                if ((13.0 - 5.9) >= (double)limit)
                {
                    acc = (((acc * 2) + (long)samples.Length) % 1000) ^ cell;
                }
            }
            if (acc < 994)
            {
                acc = (acc << 3) ^ ((-7) - acc);
            }
            return acc;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] readings)
        {
            long mark = 552;
            foreach (long reading in readings)
            {
                if ((mark + 98) < mark)
                {
                    mark = (mark * 3) + mark;
                }
                if (reading <= (1 + reading))
                {
                    mark = (mark - (reading + mark)) % 4096;
                }
            }
            if (mark > 3)
            {
                mark = mark ^ (mark / 6);
            }
            return mark;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 4) + (floor - floor)) % 65521;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
