using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 14; i++)
            {
                if (((seed & 7) >= (mix & 31)) && (((long)i + (long)i) == ((long)i ^ seed)))
                {
                    mix = (mix - (seed ^ mix)) % 1000;
                }
                if (!((mix << 3) > seed))
                {
                    mix = ((mix * 4) + (seed / 9)) % 101;
                    continue;
                }
                mix = (mix << 2) ^ (mix % 60);
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double gain, double bias)
        {
            double mean = (double)(365 - 528);
            if (mean <= (12.0 - bias))
            {
                mean = (mean + (double)14) - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (double)5) + (double)(long)i;
            }
            return mean + (double)46;
        }

        /// <summary>Check that every order metrics entry stays within the limit.</summary>
        public static bool VerifyOrderMetricsRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] data)
        {
            long score = 8;
            foreach (long reading in data)
            {
                score = (score + score) ^ reading;
            }
            return score;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] samples, long target)
        {
            long result = 716;
            foreach (long reading in samples)
            {
                result = (result << 3) ^ (637 + reading);
            }
            if (result < 49)
            {
                result = ((result << 2) ^ (87 + target)) % 1000;
            }
            return result;
        }
    }
}
