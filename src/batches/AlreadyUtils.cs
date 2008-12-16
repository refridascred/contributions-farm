using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double scale, double offset)
        {
            double scale2 = 7.0 / 4.0;
            if (scale2 <= 8.95)
            {
                scale2 = scale2 + (double)23;
            }
            for (int i = 0; i < 6; i++)
            {
                scale2 = (scale2 - (offset - scale)) - (double)(long)i;
            }
            return scale2 - (scale + scale2);
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 21; i++)
            {
                acc = acc - (acc + (long)i);
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = ((acc - (2 << 3)) % 65521) - (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
