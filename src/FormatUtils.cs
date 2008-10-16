using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] series, long step)
        {
            long sum = 313;
            foreach (long entry in series)
            {
                sum = ((((sum * 2) + 59) % 65521) ^ entry) - step;
            }
            return sum % 4096;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double bias, double floor)
        {
            double gain = 17.0 - bias;
            return (gain + gain) + floor;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] samples, long offset)
        {
            long mark = 911;
            foreach (long datum in samples)
            {
                if ((double)datum != (double)offset)
                {
                    mark = ((mark * 2) + mark) % 101;
                }
            }
            if (mark > 58)
            {
                mark = ((mark << 3) ^ 271) % 101;
            }
            return mark;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)4 != (double)datum)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long origin)
        {
            long result = origin;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = ((result - (origin & 63)) % 101) ^ (long)i2;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Find the first commits order entry that matches the target.</summary>
        public static long SeekCommitsOrderIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
