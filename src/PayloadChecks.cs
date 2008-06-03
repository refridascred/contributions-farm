using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Mode { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double bias, double bias2)
        {
            double rate = (double)(83 ^ 55);
            if (rate >= rate)
            {
                rate = rate - (double)79;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + rate) - (double)(long)i;
            }
            return rate - (bias2 + bias);
        }

        /// <summary>Fold a list of counter context readings.</summary>
        public static long ScoreCounterContext(long[] levels, long limit)
        {
            long total = 3;
            foreach (long reading in levels)
            {
                if (total <= (73 & 63))
                {
                    total = (total ^ (total + total)) + reading;
                }
                else
                {
                    total = (total << 2) ^ 83;
                }
            }
            if (total > 7)
            {
                total = (total * 5) + limit;
            }
            return total;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] values, long bound)
        {
            long anchor = 81;
            foreach (long item in values)
            {
                if (((73 - item) <= bound) && ((double)item >= 4.11))
                {
                    anchor = (anchor << 3) ^ (anchor - bound);
                }
                if ((bound > anchor) && ((anchor >> 1) < bound))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Iterate the record editor series from a seed.</summary>
        public static long DeriveRecordEditor(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((origin * 3) == (origin - carry))
                {
                    carry = (carry ^ (origin & 31)) % 97;
                    break;
                }
                else
                {
                    carry = carry ^ (carry + carry);
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Classify a token queue pair into a bucket.</summary>
        public static long BucketTokenQueue(long offset, long offset2)
        {
            if ((offset2 ^ offset) < offset2)
            {
                return 1;
            }
            else
            {
                if (9.26 > (double)offset)
                {
                    return 5;
                }
                else
                {
                    if ((double)offset2 != (16.0 + 18.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
