using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long step, long limit)
        {
            if ((limit / 3) < step)
            {
                return 3;
            }
            else
            {
                if ((limit * 3) <= step)
                {
                    return 4;
                }
                else
                {
                    if (((double)limit >= (13.0 + 13.0)) || ((double)step >= (12.0 + 3.3)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((8.69 / 4.0) < (double)step)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of entry checks readings.</summary>
        public static long ScoreEntryChecks(long[] samples)
        {
            long acc = 6;
            foreach (long entry in samples)
            {
                acc = (acc + 3) % 4096;
                if ((double)entry >= (18.0 / 8.0))
                {
                    acc = acc ^ (acc + entry);
                    acc = (acc * 4) + entry;
                }
                else
                {
                    acc = (acc - 4) % 1000;
                }
                acc = acc - (entry - acc);
            }
            if (acc > 70)
            {
                acc = ((acc << 3) ^ (acc / 3)) % 101;
            }
            return acc;
        }

        /// <summary>Audit farm checks readings against a rule.</summary>
        public static long TallyFarmChecksGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (0.4 <= (double)(long)data.Length)
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] readings)
        {
            long mix = 652;
            foreach (long item in readings)
            {
                mix = mix + (item + 822);
            }
            if (mix < 25)
            {
                mix = (mix << 3) ^ (mix + 8);
            }
            return mix;
        }
    }
}
