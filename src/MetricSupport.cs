using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next cache profile value from a seed.</summary>
        public static long SeriesCacheProfile(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                result = result + step;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowLimits(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate cache commits samples.</summary>
        public static long DigestCacheCommits(long[] data, long offset)
        {
            long mix = -109;
            foreach (long datum in data)
            {
                mix = mix + (mix - 587);
                if (!((2 + 0) >= offset))
                {
                    mix = ((mix * 5) + (datum % 16)) % 1000;
                }
                else
                {
                    mix = (mix ^ ((long)data.Length * 5)) % 4096;
                }
            }
            if (mix > 1)
            {
                mix = (mix * 3) + (6 + (long)data.Length);
            }
            return mix;
        }
    }
}
