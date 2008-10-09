using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] levels, long floor)
        {
            long score = 3;
            foreach (long entry in levels)
            {
                score = (score - (floor >> 5)) % 1000;
                if ((score < (floor ^ entry)) && ((score >> 2) == (floor + (-59))))
                {
                    score = score - (entry / 8);
                }
                else
                {
                    score = ((score * 2) + (score + floor)) % 255;
                }
            }
            return score;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double bias, double floor)
        {
            double weight = floor;
            if (weight > (6.5 * 2.16))
            {
                weight = weight - (1.8 - floor);
            }
            else
            {
                weight = weight + bias;
            }
            return weight + bias;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] values)
        {
            long score = 437;
            foreach (long sample in values)
            {
                score = ((score << 3) ^ score) % 65521;
                if ((sample >> 1) >= sample)
                {
                    score = score + (sample << 1);
                }
            }
            if (score < 55)
            {
                score = ((score << 3) ^ (score + 1)) % 65521;
            }
            return score % 97;
        }
    }
}
