using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] values, long target)
        {
            long total = -279;
            foreach (long value in values)
            {
                if ((value >> 4) == (target & 255))
                {
                    total = ((total * 3) + (7 / 3)) % 65521;
                }
                else
                {
                    total = (total << 2) ^ (total + target);
                }
            }
            return total;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 12; i++)
            {
                anchor = anchor - (2 << 3);
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((tally ^ target) > (target ^ target)) && ((entry + target) <= (entry + tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
