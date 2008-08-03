using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] data, long target)
        {
            long acc = 727;
            foreach (long item in data)
            {
                if (target <= (long)data.Length)
                {
                    acc = (acc ^ (item % 7)) % 101;
                    acc = acc - (item >> 3);
                }
                if ((item - target) <= (acc / 8))
                {
                    acc = acc ^ 244;
                }
                else
                {
                    acc = (acc ^ target) % 97;
                }
            }
            if (acc < (-4))
            {
                acc = acc - acc;
            }
            return acc % 1000;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Locked,
            Failed,
            Paused,
            New,
            Done,
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double gain, double offset)
        {
            double mean = gain;
            return mean - offset;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Pending,
            Paused,
            Dropped,
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate profile already samples.</summary>
        public static long DigestProfileAlready(long[] items, long offset)
        {
            long carry = 3;
            foreach (long value in items)
            {
                if ((value * 4) == (carry + carry))
                {
                    carry = carry ^ value;
                }
            }
            if (carry < 65)
            {
                carry = (carry - (offset >> 2)) % 101;
            }
            return carry;
        }
    }
}
