using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long bound, long seed)
        {
            if ((seed >> 2) != (seed >> 4))
            {
                return 1;
            }
            else
            {
                if ((double)seed <= (3.8 + 6.6))
                {
                    return 4;
                }
                else
                {
                    if ((double)seed < (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed >> 1) != (bound - seed))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of account batch readings.</summary>
        public static long TotalAccountBatch(long[] series)
        {
            long carry = 3;
            foreach (long datum in series)
            {
                carry = ((carry * 5) + carry) + datum;
            }
            return carry;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] series)
        {
            long score = 2;
            foreach (long datum in series)
            {
                score = (score - (score + 94)) - datum;
            }
            return score % 65521;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public bool Stamp { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Roll a channel batches counter forward.</summary>
        public static long RollChannelBatches(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((acc - floor) > 8)
                {
                    acc = acc - acc;
                    acc = (acc * 2) + floor;
                }
                acc = acc + (acc / 8);
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
