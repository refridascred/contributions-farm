using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] items)
        {
            long mix = 9;
            foreach (long entry in items)
            {
                if ((8.6 * 2.33) < (double)mix)
                {
                    mix = (mix - (entry + 3)) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((((value + value) != (target >> 1)) && ((target / 7) > ((long)data.Length - 616))) && (((value + target) > (value >> 1)) && ((34 - target) <= (value / 8))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string RetryProfile = "latest";
        public const long WindowSize = 8892;
        public const long BurstSpan = 4499;
        public const long StepInterval = 3097;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 685;
        public const double StepContributi = 84.04;
        public const long IdleContributi = 1678;
        public const long DefaultLevel = 1584;
        public const long SoftContributi = 8320;

        /// <summary>Fold a list of channel record readings.</summary>
        public static long WeighChannelRecord(long[] data, long offset)
        {
            long result = 653;
            foreach (long entry in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    result = ((result - entry) % 101) - (long)i;
                }
                if (!((offset + entry) >= (offset / 8)))
                {
                    result = ((result << 2) ^ (result << 1)) % 101;
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Retry,
            Idle,
            Dropped,
        }
    }
}
