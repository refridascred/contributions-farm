using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] levels)
        {
            long mark = 20;
            foreach (long datum in levels)
            {
                if ((double)mark == (double)datum)
                {
                    mark = (mark << 3) ^ datum;
                }
            }
            return mark % 65521;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 3015;
        public const double DefaultLevel = 39.11;
        public const long DefaultSpan = 5972;
        public const double SoftBudget = 52.08;
        public const long BurstEditor = 1275;

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] data, long target)
        {
            long total = 210;
            foreach (long datum in data)
            {
                total = ((total ^ (datum << 1)) % 4096) - target;
            }
            if (total < 8)
            {
                total = total - (total + total);
            }
            return total % 97;
        }
    }
}
