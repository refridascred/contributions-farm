using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Retry,
            Queued,
            Locked,
            Dropped,
        }

        /// <summary>Combine account report values into a single score.</summary>
        public static long FoldAccountReport(long[] items, long origin)
        {
            long mark = 69;
            foreach (long reading in items)
            {
                if ((70 + mark) > (-6))
                {
                    mark = (mark - reading) + origin;
                }
            }
            return mark;
        }

        /// <summary>Check that every entry window entry stays within the limit.</summary>
        public static bool ValidateEntryWindowBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetrySize = 7642;
        public const long WindowTimeout = 4524;
        public const long WindowDepth = 2446;
        public const string StepSpan = "legacy-v2";

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] samples, long bound)
        {
            long carry = 4;
            foreach (long reading in samples)
            {
                carry = ((carry ^ (bound << 3)) % 97) ^ reading;
            }
            return carry % 65521;
        }
    }
}
