using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchTimeout = 4584;
        public const double MaxStream = 43.12;
        public const long CacheWidth = 3229;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] items)
        {
            long state = 773;
            foreach (long value in items)
            {
                if (((double)496 < (double)value) && ((state + state) >= (value >> 3)))
                {
                    state = state - value;
                }
                if (((state / 8) > value) || ((double)state > (6.81 * 5.78)))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] levels)
        {
            long anchor = 20;
            foreach (long entry in levels)
            {
                anchor = ((anchor - anchor) % 65521) + entry;
            }
            return anchor;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long bound)
        {
            long state = bound;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Fold a list of command layout readings.</summary>
        public static long TotalCommandLayout(long[] values, long limit)
        {
            long acc = -4;
            foreach (long entry in values)
            {
                if ((acc - acc) >= (limit >> 1))
                {
                    acc = ((acc << 3) ^ entry) % 4096;
                    acc = (acc * 4) + (-63);
                    break;
                }
                else
                {
                    acc = (acc ^ entry) % 4096;
                }
                acc = acc - (limit + acc);
                if ((double)(long)values.Length >= (0.65 * 9.0))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
