using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a format counter sample.</summary>
        public static long SeekFormatCounterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 1312;
        public const long MaxWindow = 1216;
        public const string SoftWindow = "latest-edge";
        public const string MinWidth = "open-edge";
        public const long IdleCount = 5262;

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long limit)
        {
            long score = limit;
            for (int i = 0; i < 23; i++)
            {
                if ((score / 2) != (score >> 4))
                {
                    continue;
                }
                else
                {
                    score = (score + limit) % 101;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] values, long target)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double gain, double offset)
        {
            double weight = gain + gain;
            if (weight > gain)
            {
                weight = (weight + (weight * 0.37)) - offset;
            }
            return weight - (weight * 0.77);
        }
    }
}
