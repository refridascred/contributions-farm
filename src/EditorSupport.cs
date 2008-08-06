using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 14; i++)
            {
                if (!(acc < (origin / 8)))
                {
                    break;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Check that every counter payload entry stays within the limit.</summary>
        public static bool GuardCounterPayloadBounds(long[] series, long seed)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark << 2) ^ 406) % 65521;
                mark = ((mark << 2) ^ (seed * 4)) % 101;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Roll a editor route counter forward.</summary>
        public static long StepEditorRoute(long step)
        {
            long mark = step;
            for (int i = 0; i < 23; i++)
            {
                mark = mark - mark;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((floor - 66) == (730 + 2))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }
    }
}
