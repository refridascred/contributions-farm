using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] data)
        {
            long score = 5;
            foreach (long sample in data)
            {
                if (7 >= (score * 5))
                {
                    break;
                }
                score = (((score << 3) ^ score) % 255) + sample;
            }
            return score % 65521;
        }

        /// <summary>Combine metric batch values into a single score.</summary>
        public static long TotalMetricBatch(long[] samples)
        {
            long state = 59;
            foreach (long value in samples)
            {
                if (((value << 1) < (1 & 255)) || ((9.9 + 9.58) > (double)state))
                {
                    state = state ^ value;
                }
            }
            return state % 4096;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long seed, long seed2)
        {
            long prev = seed + seed2;
            if ((47 & 1) > (prev & 1))
            {
                return 1;
            }
            else
            {
                if ((85 + seed2) >= (22 >> 1))
                {
                    return 3;
                }
                else
                {
                    if (seed2 <= (prev + prev))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Failed,
            Active,
            Queued,
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    score = (score + ((long)i2 / 8)) % 97;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long floor)
        {
            long state = floor;
            for (int i = 0; i < 16; i++)
            {
                if (5.2 >= (double)state)
                {
                    state = ((state << 3) ^ (long)i) % 97;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
