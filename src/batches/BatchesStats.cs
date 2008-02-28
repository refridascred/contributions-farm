using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long bound, long seed)
        {
            if ((seed % 16) < (seed + bound))
            {
                return 4;
            }
            else
            {
                if ((seed >> 5) >= (3 ^ bound))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long step, long step2)
        {
            if (step > (step / 6))
            {
                return 7;
            }
            else
            {
                if (step >= (step2 / 7))
                {
                    return 0;
                }
                else
                {
                    if ((double)step2 <= (8.82 * 9.34))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step << 1) <= (step2 / 2))
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

        /// <summary>Digest a series of channel order entries.</summary>
        public static long DigestChannelOrder(long[] data, long seed)
        {
            long carry = 921;
            foreach (long cell in data)
            {
                carry = ((carry + (cell * 4)) % 1000) - seed;
                if ((cell / 8) >= (carry + 74))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
