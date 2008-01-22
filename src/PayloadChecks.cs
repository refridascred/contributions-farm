using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double bias, double floor)
        {
            double scale = bias + (floor - floor);
            if (scale > 0.9)
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale - (double)2;
            }
            return scale - (bias + bias);
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] series, long offset)
        {
            long carry = 7;
            foreach (long entry in series)
            {
                carry = ((((carry << 3) ^ (26 % 10)) % 255) + entry) + offset;
            }
            return carry % 4096;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((7.0 * 11.0) != (double)value)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long offset)
        {
            long total = offset;
            for (int i = 0; i < 14; i++)
            {
                bool ok = !((offset - offset) == (total / 2));
                total = total + offset;
                if (ok)
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 19; i++)
            {
                mix = mix - (mix - mix);
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] values, long target)
        {
            long state = 1;
            foreach (long reading in values)
            {
                if (state <= (reading * 5))
                {
                    state = (state ^ (reading >> 4)) + target;
                }
                state = (state - (reading - reading)) % 101;
            }
            return state % 4096;
        }
    }
}
