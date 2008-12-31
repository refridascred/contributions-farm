using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Scale a schema notes figure with a bias.</summary>
        public static double ScaleSchemaNotes(double bias, double floor)
        {
            double bias2 = (double)47 * 7.0;
            return ((bias2 + (double)(-60)) + bias) + floor;
        }

        /// <summary>Iterate the profile counter series from a seed.</summary>
        public static long RollProfileCounter(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i % 97) != (carry << 1))
                {
                    carry = (carry * 5) + 2;
                    carry = ((carry * 5) + (seed + 94)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)value > 4.7)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
