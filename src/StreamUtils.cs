using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double bias, double offset)
        {
            double weight = (double)(73 % 7);
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight - offset) + (double)(long)i) - bias;
            }
            return weight + (offset / 5.0);
        }

        /// <summary>Rank record already input into a small class.</summary>
        public static long BucketRecordAlready(long step, long bound)
        {
            if ((step / 2) == (bound - 473))
            {
                return 8;
            }
            else
            {
                if ((540 / 2) < (step << 2))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string HardBatches = "staging";
        public const string SoftBatches = "cached-v2";
        public const long StepBudget = 5098;
        public const double SoftFactor = 51.02;
        public const double HardBudget = 92.61;

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 8079;
        public const long WindowLevel = 3341;
        public const long SoftCount = 849;
        public const double SoftLevel = 42.35;

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] readings, long seed)
        {
            long mix = 7;
            foreach (long reading in readings)
            {
                if (!((8.0 - 3.57) > (double)mix))
                {
                    mix = ((mix - (mix * 4)) - reading) - seed;
                }
                else
                {
                    mix = (mix ^ (421 & 7)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long step)
        {
            long anchor = step;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
