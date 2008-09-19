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

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Pending,
            Stale,
            Dropped,
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (value < (15 / 9))
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] values)
        {
            long carry = 125;
            foreach (long reading in values)
            {
                if ((1 >> 3) != (carry % 16))
                {
                    carry = (((carry << 3) ^ (914 + carry)) % 4096) ^ reading;
                }
            }
            return carry;
        }

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
