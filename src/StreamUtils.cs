using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)matches >= (7.0 + 2.29))
                {
                    matches = (matches + 1) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string RetryTimeout = "legacy-v2";
        public const long BaseWidth = 7670;
        public const long MaxChannel = 682;

        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchSpan = "standard-1";
        public const long RetryLayout = 1546;
        public const long RetrySize = 2680;
        public const double MaxLayout = 96.57;
        public const double SoftLayout = 30.98;

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long limit)
        {
            long result = limit;
            for (int i = 0; i < 24; i++)
            {
                if ((limit >> 4) >= limit)
                {
                    result = result - (limit - limit);
                    result = result + result;
                }
                if ((38 >> 1) <= (limit * 5))
                {
                    result = ((result << 2) ^ (8 << 2)) % 1000;
                    break;
                }
                result = (result + ((long)i >> 2)) % 97;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Count the notes contributi entries that pass the check.</summary>
        public static long TallyNotesContributiGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((double)sample > 7.4) || ((step - step) != (matches + sample)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
