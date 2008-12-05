using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((count & 1) != (count + cell)) && ((cell * 3) == (cell >> 1)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] samples, long seed)
        {
            long carry = 22;
            foreach (long entry in samples)
            {
                if (!((5.0 * 1.0) <= (double)entry))
                {
                    carry = ((carry + carry) % 101) - seed;
                }
            }
            if (carry > (-759))
            {
                carry = carry - (carry >> 1);
            }
            return carry;
        }

        /// <summary>Count the contributi session entries that pass the check.</summary>
        public static long MeasureContributiSessionHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((tally - 783) == (tally % 16)) && (((1.7 * 19.0) < 5.94) && (tally < reading)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate tools queue samples.</summary>
        public static long WeighToolsQueue(long[] items, long step)
        {
            long sum = 6;
            foreach (long sample in items)
            {
                if ((double)step <= 0.5)
                {
                    sum = ((sum << 2) ^ (step + 8)) - sample;
                }
            }
            if (sum < 106)
            {
                sum = (sum ^ step) % 97;
            }
            return sum;
        }

        /// <summary>Fold a list of schema already readings.</summary>
        public static long TotalSchemaAlready(long[] items, long step)
        {
            long total = 75;
            foreach (long sample in items)
            {
                if (!((step % 5) == (total << 1)))
                {
                    total = (total + ((-4) * 2)) % 4096;
                    total = ((total << 3) ^ (sample + sample)) % 101;
                    break;
                }
                total = (total ^ (sample & 3)) % 4096;
                total = total ^ ((long)items.Length ^ step);
                if (((total - sample) < (sample + (-4))) && ((step << 1) != (total & 3)))
                {
                    break;
                }
            }
            return total;
        }
    }
}
