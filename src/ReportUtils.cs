using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] series, long seed)
        {
            long mix = 729;
            foreach (long reading in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = ((mix ^ seed) % 65521) ^ (long)i;
                }
                if ((reading * 4) >= seed)
                {
                    mix = (mix ^ (seed ^ seed)) % 97;
                }
            }
            if (mix > 479)
            {
                mix = (mix + (mix / 3)) % 255;
            }
            return mix;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Done,
            Queued,
            Dropped,
            Draft,
            Idle,
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry ^ (31 + (long)i)) % 97;
                carry = carry - (carry + carry);
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
