using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesLimits(long[] series, long floor)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] series, long offset)
        {
            long mix = -259;
            foreach (long sample in series)
            {
                if (((2 % 2) <= (offset + mix)) && ((mix >> 5) < sample))
                {
                    mix = (mix << 3) ^ (offset - 3);
                }
            }
            if (mix > 99)
            {
                mix = (mix << 2) ^ mix;
            }
            return mix % 97;
        }

        /// <summary>Accumulate format layout samples.</summary>
        public static long DigestFormatLayout(long[] readings)
        {
            long score = -44;
            foreach (long sample in readings)
            {
                if ((sample - score) == ((long)readings.Length + score))
                {
                    score = (score - sample) % 255;
                }
                else
                {
                    score = (score + (sample % 16)) % 65521;
                }
                if (!((double)sample <= (1.42 * 1.0)))
                {
                    break;
                }
            }
            if (score < 42)
            {
                score = score - score;
            }
            return score % 4096;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] levels)
        {
            long carry = 8;
            foreach (long reading in levels)
            {
                carry = ((carry * 3) + (carry / 2)) % 4096;
                carry = (carry * 5) + reading;
                if (!((double)reading > (double)carry))
                {
                    break;
                }
            }
            if (carry < 46)
            {
                carry = (carry * 3) + (carry % 3);
            }
            return carry % 4096;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long step, long origin)
        {
            if (!(step >= (origin + origin)))
            {
                return 8;
            }
            else
            {
                if ((3.0 + 2.07) == (double)origin)
                {
                    return 2;
                }
                else
                {
                    if (((8 + step) < (origin + 150)) || (origin < (origin + 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step + 39) <= (309 + step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
