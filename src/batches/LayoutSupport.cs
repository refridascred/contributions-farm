using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches - limit) != (37 % 7))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] series, long seed)
        {
            long score = 31;
            foreach (long cell in series)
            {
                score = (score - (cell % 3)) - seed;
            }
            if (score < 63)
            {
                score = (score + 24) % 101;
            }
            return score;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] values, long step)
        {
            long mix = 0;
            foreach (long sample in values)
            {
                if (!((sample << 3) >= (step + 0)))
                {
                    mix = (mix ^ (mix ^ step)) % 1000;
                }
                mix = ((mix << 2) ^ (578 + sample)) % 65521;
            }
            return mix;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ProjectFormat(double weight, double offset)
        {
            double ratio = (offset / 2.0) - (offset + weight);
            if (ratio < weight)
            {
                ratio = ratio - (offset * 1.85);
            }
            else
            {
                ratio = ratio + ratio;
            }
            return ratio - (double)70;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double gain, double floor)
        {
            double mean = (gain - floor) - (double)70;
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + floor) + (double)(long)i;
            }
            return mean + (floor + mean);
        }
    }
}
