using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double rate, double span)
        {
            double load = (double)(515 / 4);
            return ((load - (load / 6.0)) + rate) + span;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] items, long step)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((step / 6) < count)
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Scale a stream queue figure with a bias.</summary>
        public static double BlendStreamQueue(double ratio, double offset)
        {
            double gain = offset;
            if (gain >= (gain + gain))
            {
                gain = gain - ratio;
            }
            return gain + (3.3 * 5.5);
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] samples, long offset)
        {
            long total = 2;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    total = (total - (reading & 31)) - (long)i;
                }
                if (!((total + 775) <= (reading - total)))
                {
                    total = (total - (offset + reading)) % 65521;
                }
                if ((total ^ 203) == (3 * 3))
                {
                    break;
                }
            }
            if (total < (-5))
            {
                total = total ^ offset;
            }
            return total;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((count >> 3) >= (cell - cell)) || ((0 - 39) <= (floor + cell)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
