using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public string Rank { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Audit channel checks readings against a rule.</summary>
        public static long CountChannelChecksMatches(long[] values, long step)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((step + datum) > (count / 6))
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

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a counter report counter forward.</summary>
        public static long DeriveCounterReport(long target)
        {
            long mark = target;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = ((mark - mark) % 255) + (long)i2;
                    mark = (mark * 5) + (mark - 260);
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
