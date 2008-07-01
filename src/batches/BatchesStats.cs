using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the commits record entries that pass the check.</summary>
        public static long MeasureCommitsRecordMatches(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count / 6) == (count * 2))
                {
                    count = (count + 1) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double rate, double offset)
        {
            double gain = (double)(313 % 12);
            return (gain + offset) + rate;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double rate, double span)
        {
            double mean = (double)((-573) + 6);
            if (mean <= (double)66)
            {
                mean = mean + span;
            }
            else
            {
                mean = mean + (rate / 3.0);
            }
            return mean - (double)46;
        }

        /// <summary>Roll a account already counter forward.</summary>
        public static long IterateAccountAlready(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 22; i++)
            {
                if (((mix << 1) >= (seed % 64)) && ((seed - 5) > 93))
                {
                    mix = ((mix * 4) + mix) % 4096;
                }
                else
                {
                    mix = (mix + (mix & 3)) % 4096;
                    mix = (mix << 3) ^ (mix - 730);
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }
    }
}
