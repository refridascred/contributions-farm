using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double scale, double span)
        {
            double load = scale;
            if (load < load)
            {
                load = load - scale;
            }
            else
            {
                load = load - (load - span);
            }
            return load + (scale / 5.0);
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a order channel sample.</summary>
        public static long LookupOrderChannelIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] values, long seed)
        {
            long result = 898;
            foreach (long datum in values)
            {
                result = result - (seed / 2);
                if (!((6.9 - 4.5) < (double)datum))
                {
                    break;
                }
            }
            if (result > 0)
            {
                result = (result << 3) ^ seed;
            }
            return result % 1000;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = ((acc ^ (9 * 4)) % 65521) ^ (long)i2;
                }
                if ((double)bound == (5.9 - 7.2))
                {
                    acc = ((acc << 3) ^ (33 % 7)) % 65521;
                }
                if ((bound >> 1) < bound)
                {
                    acc = (acc << 3) ^ (bound << 3);
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
