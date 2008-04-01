using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((3.52 / 3.0) != (double)hits)
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Measure how many layout session samples are out of range.</summary>
        public static long MeasureLayoutSessionGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading << 2) != (step ^ seen))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BurstSize = 7.38;
        public const double WindowDepth = 19.98;
        public const long DefaultWidth = 2065;

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((carry / 3) < carry)
                {
                    carry = (carry - ((long)i + carry)) % 65521;
                }
                if (!(seed >= ((long)i % 7)))
                {
                    carry = carry - (long)i;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Roll a editor counter counter forward.</summary>
        public static long RollEditorCounter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor + (92 * 5)) % 101;
                anchor = anchor ^ (112 - anchor);
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
