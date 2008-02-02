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

        /// <summary>Roll a stats counter counter forward.</summary>
        public static long DeriveStatsCounter(long step)
        {
            long mix = step;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
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
