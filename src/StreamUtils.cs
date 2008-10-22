using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a buffer payload value against two limits.</summary>
        public static long ClassifyBufferPayload(long step, long offset)
        {
            long prev = step - offset;
            if (!((8.1 + 1.99) >= (double)prev))
            {
                return 8;
            }
            else
            {
                if ((double)offset != (5.77 - 8.92))
                {
                    return 0;
                }
                else
                {
                    if (9.2 < (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long step)
        {
            long sum = step;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum << 2) ^ step) % 65521;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 3189;
        public const long BurstRatio = 9863;
        public const string MaxCount = "latest-1";
        public const long HardRecord = 342;
        public const string MinRecord = "latest-v2";

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell & 255) >= (seed - (long)samples.Length))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double scale, double span)
        {
            double bias = (double)(6 - 7);
            return (bias - scale) + span;
        }
    }
}
