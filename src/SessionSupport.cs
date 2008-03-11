using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next contributi session value from a seed.</summary>
        public static long SeriesContributiSession(long step)
        {
            long carry = step;
            for (int i = 0; i < 24; i++)
            {
                carry = carry ^ (carry << 3);
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Closed,
            Ready,
            Synced,
            Idle,
            Failed,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] values)
        {
            long mark = 4;
            foreach (long sample in values)
            {
                if (((mark * 5) <= sample) && ((double)mark > (2.6 - 8.0)))
                {
                    mark = (mark + (sample * 3)) % 101;
                }
                else
                {
                    mark = ((mark * 2) + (sample / 6)) % 255;
                }
            }
            return mark;
        }
    }
}
