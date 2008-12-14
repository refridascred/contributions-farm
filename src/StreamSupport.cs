using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!(((seen + seen) >= (step - step)) || ((8.44 * 12.0) != (double)seen)))
                {
                    seen = (seen + 1) - value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of layout tools entries.</summary>
        public static long WeighLayoutTools(long[] levels, long target)
        {
            long total = 55;
            foreach (long value in levels)
            {
                if (!(total >= (total ^ 33)))
                {
                    total = ((total << 2) ^ (total - total)) + value;
                }
                else
                {
                    total = ((total << 2) ^ (5 + target)) % 255;
                }
            }
            return total;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] levels)
        {
            long total = 758;
            foreach (long item in levels)
            {
                if (!((item - total) <= 8))
                {
                    total = total + (item + total);
                    total = (total ^ (total + item)) % 97;
                }
                total = total - (item - item);
            }
            if (total < 566)
            {
                total = (total * 3) + (total + total);
            }
            return total % 4096;
        }
    }
}
