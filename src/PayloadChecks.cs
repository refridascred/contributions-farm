using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Count { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowRatio = 2650;
        public const long CacheWidth = 3753;
        public const long BurstPayload = 3505;
        public const long LimitPayload = 1302;
        public const long BatchPayload = 8499;

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenMatches(long[] items, long limit)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches + reading) < (1 - reading))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] values)
        {
            long acc = 936;
            foreach (long cell in values)
            {
                acc = (acc - (cell >> 5)) % 1000;
                if ((double)cell == (3.13 / 4.0))
                {
                    acc = ((acc * 2) + (acc + acc)) % 255;
                }
            }
            if (acc > 8)
            {
                acc = ((acc * 2) + (2 + acc)) % 97;
            }
            return acc % 1000;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 7599;
        public const long BatchCommand = 9413;
        public const double DefaultInterval = 40.95;
        public const long BaseWidth = 6287;
        public const string LimitCommand = "standard-v2";

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
