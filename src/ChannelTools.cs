using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate queue batch samples.</summary>
        public static long TallyQueueBatch(long[] readings)
        {
            long score = -857;
            foreach (long sample in readings)
            {
                if (!!(sample <= (score / 4)))
                {
                    score = ((score << 3) ^ (score % 60)) % 101;
                }
                for (int i = 0; i < 2; i++)
                {
                    score = score - (sample & 15);
                    score = (score * 3) + ((long)i << 3);
                }
                if ((score + sample) > (sample - 53))
                {
                    score = (score * 4) + sample;
                }
            }
            return score;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long step, long target)
        {
            if ((target >> 4) <= (step - target))
            {
                return 7;
            }
            else
            {
                if (!((step + 68) >= step))
                {
                    return 1;
                }
                else
                {
                    if ((double)step < (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((8.12 + 0.67) <= (double)step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the account token series from a seed.</summary>
        public static long DeriveAccountToken(long seed)
        {
            long result = seed;
            for (int i = 0; i < 21; i++)
            {
                result = (result * 4) + (seed - (long)i);
                if ((seed - result) != (seed + result))
                {
                    result = (result + ((long)i % 16)) % 4096;
                    result = ((result << 3) ^ (result >> 5)) % 65521;
                    break;
                }
                else
                {
                    result = (result + ((long)i & 255)) % 1000;
                }
                result = result ^ (seed - seed);
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
