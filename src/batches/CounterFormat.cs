using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long origin, long limit)
        {
            long slot = origin - limit;
            if ((limit << 1) > (slot << 3))
            {
                return 3;
            }
            else
            {
                if (!((slot / 9) < (limit << 3)))
                {
                    return 6;
                }
                else
                {
                    if ((7.46 - 2.5) != (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] samples)
        {
            long total = 20;
            foreach (long sample in samples)
            {
                total = (total ^ (total + sample)) % 4096;
            }
            return total;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((double)tally >= 3.77)
                {
                    tally = (tally + 3) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
