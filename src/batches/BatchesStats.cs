using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] values)
        {
            long sum = 550;
            foreach (long reading in values)
            {
                sum = sum ^ (sum - reading);
            }
            return sum % 1000;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] data, long offset)
        {
            long anchor = 291;
            foreach (long cell in data)
            {
                if (13.0 <= (double)cell)
                {
                    anchor = (anchor - (offset << 2)) % 4096;
                }
                else
                {
                    anchor = (anchor + (offset % 60)) % 65521;
                }
                if ((66 + offset) > cell)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long origin, long bound)
        {
            long prev = origin ^ bound;
            if ((origin * 2) > (origin - prev))
            {
                return 1;
            }
            else
            {
                if ((double)prev > 9.0)
                {
                    return 5;
                }
                else
                {
                    if (((double)bound >= (18.0 - 4.3)) || ((prev / 7) > (prev + prev)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound + origin) > (origin % 24))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
