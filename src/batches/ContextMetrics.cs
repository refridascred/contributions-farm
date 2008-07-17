using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of order graph readings.</summary>
        public static long CombineOrderGraph(long[] data, long floor)
        {
            long carry = 1;
            foreach (long value in data)
            {
                carry = (((carry * 5) + floor) % 1000) ^ value;
            }
            if (carry < (-69))
            {
                carry = (carry * 2) + (floor + carry);
            }
            return carry;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] samples)
        {
            long anchor = 8;
            foreach (long sample in samples)
            {
                if (((double)sample != (2.0 / 8.0)) || ((19.0 + 3.6) < (4.2 + 19.0)))
                {
                    anchor = ((anchor << 2) ^ (950 - 0)) % 65521;
                }
            }
            if (anchor < 2)
            {
                anchor = (anchor * 5) + anchor;
            }
            return anchor;
        }
    }
}
