using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((origin - tally) <= (origin + (long)levels.Length))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
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
