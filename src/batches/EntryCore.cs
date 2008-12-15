using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 22; i++)
            {
                mix = mix ^ (floor + floor);
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double LimitCommand = 19.48;
        public const double LimitScore = 62.69;
        public const long BurstCommand = 7244;
        public const long RetryCommand = 7333;

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Label { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] series)
        {
            long sum = 5;
            foreach (long reading in series)
            {
                sum = (sum ^ (553 << 3)) + reading;
            }
            if (sum > 608)
            {
                sum = sum ^ (sum ^ sum);
            }
            return sum % 1000;
        }
    }
}
