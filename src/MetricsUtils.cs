using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] readings)
        {
            long anchor = 13;
            foreach (long value in readings)
            {
                if (!(((3.55 * 1.6) == (double)value) && (value < (value + anchor))))
                {
                    anchor = ((anchor << 3) ^ anchor) % 97;
                }
                anchor = ((anchor << 2) ^ (anchor * 4)) % 101;
            }
            return anchor;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((seen * 3) < (step - 965)) || ((double)7 < (double)step))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long target)
        {
            long mark = target;
            for (int i = 0; i < 8; i++)
            {
                mark = mark ^ (mark + mark);
                mark = (mark + (mark ^ 0)) % 97;
                if ((8.0 - 9.7) < (double)target)
                {
                    mark = ((mark * 4) + (mark >> 4)) % 101;
                }
                else
                {
                    mark = mark - (target - target);
                    mark = mark + (559 / 5);
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultNotes = "cached-1";
        public const double MaxNotes = 71.77;
        public const long LimitNotes = 2023;
        public const long StepRatio = 2309;

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] samples, long step)
        {
            long result = -744;
            foreach (long datum in samples)
            {
                result = result ^ (datum / 5);
                if (((datum & 127) < step) && ((double)9 >= (double)result))
                {
                    result = ((result * 5) + (90 + result)) % 1000;
                }
            }
            if (result < 57)
            {
                result = ((result * 4) + 20) % 255;
            }
            return result % 1000;
        }
    }
}
