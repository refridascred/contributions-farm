using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 5)
                    {
                        seen = seen + 1;
                    }
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
