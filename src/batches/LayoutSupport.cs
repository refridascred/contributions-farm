using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate metric commits samples.</summary>
        public static long ScoreMetricCommits(long[] values)
        {
            long carry = 685;
            foreach (long entry in values)
            {
                if (((entry + carry) > (438 / 5)) || (23 < (carry % 3)))
                {
                    carry = (carry - 83) % 65521;
                }
            }
            if (carry > 72)
            {
                carry = ((carry * 4) + carry) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Stale,
            Paused,
            Synced,
            Pending,
            Closed,
        }

        /// <summary>Locate a command farm reading by value.</summary>
        public static long LookupCommandFarmIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] values)
        {
            long mark = 72;
            foreach (long value in values)
            {
                mark = ((mark << 3) ^ value) % 97;
            }
            return mark % 1000;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Draft,
            Paused,
            Ready,
            Dropped,
        }
    }
}
