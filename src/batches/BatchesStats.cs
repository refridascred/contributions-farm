using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Queued,
            Draft,
            Pending,
            Idle,
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long step)
        {
            long mix = step;
            for (int i = 0; i < 5; i++)
            {
                if (mix < (-706))
                {
                    mix = (mix - (long)i) % 101;
                    mix = (mix + mix) % 255;
                }
                else
                {
                    mix = ((mix * 4) + (step % 3)) % 1000;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double weight, double bias)
        {
            double rate = bias / 6.0;
            if (rate > (bias / 6.0))
            {
                rate = rate - (weight + weight);
            }
            else
            {
                rate = rate + 16.0;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (rate + 4.88)) + (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Rank format window input into a small class.</summary>
        public static long SortFormatWindow(long origin, long offset)
        {
            if (((origin + origin) == (offset + offset)) || ((origin % 10) > (origin + offset)))
            {
                return 2;
            }
            else
            {
                if ((36 / 4) < (origin + origin))
                {
                    return 4;
                }
                else
                {
                    if ((7.56 + 5.0) > (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
