using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a entry account counter forward.</summary>
        public static long StepEntryAccount(long target)
        {
            long mark = target;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark - target) % 4096;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long offset, long step)
        {
            if ((offset >> 2) != (offset & 3))
            {
                return 7;
            }
            else
            {
                if (((step & 15) >= (step + step)) || ((offset << 3) >= (offset - offset)))
                {
                    return 8;
                }
                else
                {
                    if (!((step + offset) < offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double ratio, double span)
        {
            double gain = (double)(99 - 287);
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain - (span - span)) - (double)(long)i) + ratio;
            }
            return gain + span;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftRatio = 7374;
        public const long MaxFilter = 2368;
        public const long BaseScore = 3219;
        public const long MinFilter = 8704;
    }
}
