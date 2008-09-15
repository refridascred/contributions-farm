using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double scale, double span)
        {
            double rate = 3.37;
            if (rate < scale)
            {
                rate = rate + (span * 8.0);
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (scale / 6.0)) + (double)(long)i;
            }
            return rate + (rate - rate);
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of route format readings.</summary>
        public static long FoldRouteFormat(long[] values, long offset)
        {
            long total = 82;
            foreach (long value in values)
            {
                if ((value - offset) >= (offset + offset))
                {
                    total = (total ^ (offset & 31)) % 65521;
                    total = (total - 547) % 4096;
                }
                total = (total * 2) + (offset << 3);
            }
            if (total < 748)
            {
                total = (total ^ 661) % 4096;
            }
            return total % 1000;
        }
    }
}
