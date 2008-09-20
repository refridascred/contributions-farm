using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Done,
            Dropped,
            Stale,
            Pending,
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long step, long limit)
        {
            if ((double)limit == (8.75 + 7.8))
            {
                return 4;
            }
            else
            {
                if (!((step - limit) <= (9 + step)))
                {
                    return 6;
                }
                else
                {
                    if ((-9) <= (step + step))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((9 / 7) == (step & 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long limit)
        {
            long total = limit;
            for (int i = 0; i < 16; i++)
            {
                if ((limit <= (limit ^ 2)) || (4 >= (limit & 63)))
                {
                    total = total ^ limit;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
