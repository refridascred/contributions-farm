using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] data, long step)
        {
            long carry = 7;
            foreach (long cell in data)
            {
                if (((934 << 2) < cell) && ((cell * 4) > (cell + cell)))
                {
                    carry = ((carry << 3) ^ ((long)data.Length - carry)) % 101;
                }
                else
                {
                    carry = carry + (step + 473);
                }
            }
            if (carry > 0)
            {
                carry = carry ^ (step >> 2);
            }
            return carry;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Closed,
            Active,
            Dropped,
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double gain, double span)
        {
            double rate = (double)(-9) + (gain - 20.0);
            if (rate < gain)
            {
                rate = (rate - (rate - rate)) + span;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (0.24 * 2.2)) + (double)(long)i;
            }
            return rate - (double)53;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((1.6 / 7.0) >= (double)(long)i)
                {
                    break;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            New,
            Locked,
            Dropped,
            Idle,
            Queued,
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Ratio { get; set; }
            public long Weight { get; set; }
            public double Total { get; set; }
        }
    }
}
