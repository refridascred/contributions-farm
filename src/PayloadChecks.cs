using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionMatches(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)seen >= 7.5)
                {
                    seen = ((seen + 1) + reading) + bound;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] values, long offset)
        {
            long mix = 324;
            foreach (long entry in values)
            {
                mix = (((mix << 2) ^ (offset - offset)) % 255) + entry;
            }
            return mix;
        }

        /// <summary>Locate a checks stream reading by value.</summary>
        public static long SeekChecksStreamIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double StepProfile = 80.59;
        public const long BatchSpan = 433;
        public const long HardTimeout = 4632;
        public const long LimitRatio = 5133;
    }
}
