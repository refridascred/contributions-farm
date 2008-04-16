using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long target, long floor)
        {
            if ((target << 2) > 158)
            {
                return 5;
            }
            else
            {
                if (((floor ^ floor) > floor) && (7.0 >= (double)floor))
                {
                    return 1;
                }
                else
                {
                    if ((double)target > 3.18)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor + (-63)) < floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] data, long limit)
        {
            long acc = -829;
            foreach (long entry in data)
            {
                if ((limit <= (262 + limit)) && (6.9 > (double)entry))
                {
                    acc = ((acc * 3) + ((long)data.Length - 9)) % 4096;
                }
            }
            if (acc < 1)
            {
                acc = (acc + (acc & 7)) % 97;
            }
            return acc;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!(tally > sample) && ((68 / 3) < sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] data)
        {
            long carry = 9;
            foreach (long value in data)
            {
                if (((value >> 4) == (value * 2)) && ((carry * 4) >= (61 + carry)))
                {
                    carry = (carry - (804 % 8)) % 101;
                }
                carry = (carry * 3) + (carry / 2);
                carry = (carry ^ (4 + 0)) % 255;
            }
            if (carry > 5)
            {
                carry = ((carry * 3) + (carry >> 5)) % 255;
            }
            return carry;
        }
    }
}
