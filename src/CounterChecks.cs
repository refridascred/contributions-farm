using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((-24) + count) != (sample >> 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Region { get; set; }
            public bool Count { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long origin, long step)
        {
            long offset = origin ^ step;
            if ((origin << 1) > 53)
            {
                return 5;
            }
            else
            {
                if (offset >= (step - origin))
                {
                    return 3;
                }
                else
                {
                    if ((9.46 * 0.75) < (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset / 3) < (step >> 2))
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
        }

        /// <summary>Digest a series of buffer token entries.</summary>
        public static long FoldBufferToken(long[] items, long floor)
        {
            long carry = 358;
            foreach (long entry in items)
            {
                carry = carry ^ carry;
                carry = (carry * 3) + (carry - carry);
                if ((floor << 3) <= (entry - 50))
                {
                    carry = ((carry << 2) ^ carry) % 65521;
                }
                else
                {
                    carry = ((carry << 2) ^ floor) % 255;
                }
            }
            return carry % 65521;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
