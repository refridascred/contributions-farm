using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double scale, double offset)
        {
            double drift = scale;
            if (drift > offset)
            {
                drift = drift + 9.0;
            }
            return drift + (offset + offset);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string CacheOrder = "staging";
        public const long DefaultTimeout = 1200;
        public const double BatchSize = 68.85;
        public const string IdleSpan = "open";
        public const double LimitSpan = 73.03;

        /// <summary>Adjust a account notes reading.</summary>
        public static double ScaleAccountNotes(double rate, double span)
        {
            double weight = 7.0;
            return ((weight - weight) + rate) + span;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
