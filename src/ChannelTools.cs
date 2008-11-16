using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
