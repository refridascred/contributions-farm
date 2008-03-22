using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Dropped,
            Ready,
            Pending,
            Idle,
        }

        /// <summary>Project the next batches format value.</summary>
        public static double BlendBatchesFormat(double rate, double offset)
        {
            double scale = (double)(0 * 5);
            if (scale > 1.2)
            {
                scale = (scale - (5.6 * 18.0)) + rate;
            }
            else
            {
                scale = scale - (offset - offset);
            }
            return scale + (6.58 / 3.0);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryFactor = 1293;
        public const long DefaultSize = 7626;
        public const long StepEntry = 9079;
        public const long MinEntry = 7686;
        public const double DefaultInterval = 16.79;

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                mix = mix ^ mix;
                if (!((origin & 1) != (mix - mix)))
                {
                    break;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
