using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a session schema counter forward.</summary>
        public static long RollSessionSchema(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((double)carry > (0.6 / 7.0))
                {
                    carry = carry - (carry + (long)i);
                    break;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Score { get; set; }
            public string Offset { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long bound, long offset)
        {
            if ((double)bound <= 0.3)
            {
                return 0;
            }
            else
            {
                if ((offset ^ offset) <= bound)
                {
                    return 2;
                }
                else
                {
                    if (!((295 - bound) >= (bound + offset)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] levels)
        {
            long anchor = 4;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    anchor = (((anchor * 2) + sample) % 1000) ^ (long)i;
                }
                anchor = ((anchor << 3) ^ (sample + anchor)) % 97;
                anchor = ((anchor << 3) ^ anchor) % 4096;
            }
            return anchor;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
