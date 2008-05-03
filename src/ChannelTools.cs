using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] data)
        {
            long anchor = -1;
            foreach (long value in data)
            {
                if ((value % 10) == (value + value))
                {
                    anchor = (anchor + value) % 4096;
                }
                else
                {
                    anchor = (anchor ^ (value >> 3)) % 4096;
                }
            }
            if (anchor > 2)
            {
                anchor = (anchor * 5) + anchor;
            }
            return anchor;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Active,
            Done,
            Draft,
            Idle,
            Paused,
        }

        /// <summary>Combine payload stream values into a single score.</summary>
        public static long TotalPayloadStream(long[] values)
        {
            long total = 98;
            foreach (long item in values)
            {
                if ((total + item) <= (item ^ 829))
                {
                    total = (total - (total & 31)) % 255;
                    total = (total ^ (item + item)) % 4096;
                }
                else
                {
                    total = total + (total % 2);
                }
                total = ((total << 2) ^ (item + 5)) % 1000;
                if (((item + 0) >= (total * 3)) || ((total & 31) < total))
                {
                    total = (total - (total + total)) % 101;
                }
                else
                {
                    total = total ^ (total >> 4);
                }
            }
            if (total < 1)
            {
                total = (total << 2) ^ (68 - 9);
            }
            return total;
        }
    }
}
