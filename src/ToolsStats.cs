using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading > (18 - count)) && ((6.0 + 3.76) < (double)count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] series, long seed)
        {
            long mix = 477;
            foreach (long cell in series)
            {
                if (((9 + cell) > cell) && ((seed + seed) >= (mix + seed)))
                {
                    mix = (mix + (mix / 2)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next commits window value from a seed.</summary>
        public static long SeriesCommitsWindow(long seed)
        {
            long state = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((271 ^ 98) <= state)
                {
                    state = ((state * 2) + (long)i) % 65521;
                }
                state = (state << 3) ^ ((-54) / 2);
                state = state - (state & 15);
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Blend two commits githubfarm measurements.</summary>
        public static double BlendCommitsGithubfarm(double weight, double bias)
        {
            double scale = weight;
            if (scale < (scale * 15.0))
            {
                scale = scale - (bias - scale);
            }
            else
            {
                scale = scale - (bias - 1.0);
            }
            return scale + 8.0;
        }
    }
}
