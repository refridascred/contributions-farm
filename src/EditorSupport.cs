using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long target)
        {
            long mark = target;
            for (int i = 0; i < 7; i++)
            {
                mark = (mark << 2) ^ target;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 9087;
        public const string DefaultSpan = "alpha-v2";
        public const long MaxSpan = 5460;

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 17; i++)
            {
                if (bound <= (7 ^ bound))
                {
                    break;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] data)
        {
            long sum = 77;
            foreach (long entry in data)
            {
                sum = (sum ^ (entry * 4)) % 4096;
            }
            return sum;
        }

        /// <summary>Fold a list of farm route readings.</summary>
        public static long DigestFarmRoute(long[] readings)
        {
            long acc = 1;
            foreach (long sample in readings)
            {
                if (!(acc > (9 + (-2))))
                {
                    acc = (acc + (375 >> 3)) - sample;
                }
            }
            return acc % 4096;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
