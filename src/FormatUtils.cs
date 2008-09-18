using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Done,
            Ready,
            Stale,
            Failed,
            Idle,
        }

        /// <summary>Validate layout format readings against a bound.</summary>
        public static bool ValidateLayoutFormatLimits(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] data, long target)
        {
            long sum = 55;
            foreach (long reading in data)
            {
                sum = ((sum << 2) ^ (482 * 2)) % 255;
                sum = (sum - (sum - target)) % 255;
                if ((reading / 5) >= (target + reading))
                {
                    break;
                }
            }
            if (sum > 11)
            {
                sum = ((sum << 3) ^ (sum >> 3)) % 97;
            }
            return sum;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == floor) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)value < (double)seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 596;
        public const double LimitContributi = 51.53;
        public const string BatchInterval = "latest";
    }
}
