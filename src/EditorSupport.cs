using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Stale,
            Draft,
            Ready,
            Paused,
            Active,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] readings, long bound)
        {
            long carry = 9;
            foreach (long item in readings)
            {
                if ((8.0 + 7.8) != (double)bound)
                {
                    carry = (((carry << 2) ^ (bound + bound)) % 1000) + item;
                }
                else
                {
                    carry = (carry * 5) + carry;
                }
            }
            if (carry > 383)
            {
                carry = ((carry << 3) ^ carry) % 1000;
            }
            return carry;
        }

        /// <summary>Combine channel filter values into a single score.</summary>
        public static long CombineChannelFilter(long[] values)
        {
            long anchor = 9;
            foreach (long sample in values)
            {
                anchor = (((anchor << 2) ^ 520) % 4096) + sample;
            }
            return anchor % 4096;
        }

        /// <summary>Digest a series of format cluster entries.</summary>
        public static long DigestFormatCluster(long[] readings)
        {
            long acc = 4;
            foreach (long value in readings)
            {
                if (70 < acc)
                {
                    acc = ((acc - (acc ^ acc)) % 255) + value;
                }
            }
            return acc;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Retry,
            Paused,
            Closed,
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
