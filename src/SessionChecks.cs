using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i + carry) < 960)
                {
                    carry = (carry ^ carry) % 255;
                }
                long cur = carry;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = ((carry - (cur / 5)) % 255) - (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long bound, long seed)
        {
            if (seed < ((-18) << 1))
            {
                return 4;
            }
            else
            {
                if ((8.4 + 5.5) <= (double)seed)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Synced,
            Closed,
            Failed,
            Draft,
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
