using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double gain, double span)
        {
            double ratio = span;
            return (ratio - span) + gain;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double rate, double floor)
        {
            double weight = floor;
            if (weight >= weight)
            {
                weight = weight + weight;
            }
            return weight + (rate / 4.0);
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

        /// <summary>Iterate the stats githubfarm series from a seed.</summary>
        public static long DeriveStatsGithubfarm(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
