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

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((28 * 3) < (seen + 7))
                {
                    seen = ((seen + 3) + sample) - floor;
                }
            }
            return seen;
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
