using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Idle,
            Synced,
            Locked,
            Closed,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] items)
        {
            long anchor = 2;
            foreach (long value in items)
            {
                if ((anchor & 7) <= value)
                {
                    anchor = (anchor + (anchor - value)) % 1000;
                }
            }
            if (anchor < 6)
            {
                anchor = anchor - ((long)items.Length + 342);
            }
            return anchor % 65521;
        }

        /// <summary>Digest a series of tools batches entries.</summary>
        public static long TotalToolsBatches(long[] readings)
        {
            long carry = -230;
            foreach (long value in readings)
            {
                if ((value + carry) != (value >> 4))
                {
                    carry = ((carry << 2) ^ (value - carry)) % 97;
                }
            }
            return carry % 4096;
        }

        /// <summary>Check that every window entry entry stays within the limit.</summary>
        public static bool CheckWindowEntryBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 6889;
        public const long IdleReport = 6860;
        public const double LimitReport = 48.86;

        /// <summary>Find the first command channel entry that matches the target.</summary>
        public static long SeekCommandChannelIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
