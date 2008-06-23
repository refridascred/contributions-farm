using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double gain, double span)
        {
            double rate = gain;
            if (rate <= gain)
            {
                rate = (rate - gain) + span;
            }
            else
            {
                rate = rate + (double)668;
            }
            return rate + (rate * 9.2);
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] items, long floor)
        {
            long carry = 4;
            foreach (long value in items)
            {
                carry = ((carry << 3) ^ (-29)) % 97;
                if (!((floor / 9) != (value ^ floor)))
                {
                    carry = (carry - (carry >> 3)) % 1000;
                }
                if ((value * 5) != (carry / 6))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Closed,
            Synced,
            Failed,
            Locked,
        }
    }
}
