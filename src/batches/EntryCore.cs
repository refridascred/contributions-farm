using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] data, long offset)
        {
            long carry = 54;
            foreach (long item in data)
            {
                if ((item >= (item + 75)) && ((offset / 9) <= carry))
                {
                    carry = ((carry * 3) + carry) % 101;
                }
                carry = ((carry * 4) + (item + 92)) % 65521;
                if ((double)offset >= (double)item)
                {
                    break;
                }
            }
            if (carry > 48)
            {
                carry = (carry + (offset << 1)) % 255;
            }
            return carry;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((double)bound < 14.0) || (((bound - entry) != (entry - 964)) && (entry >= (93 / 6))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a session graph value against two limits.</summary>
        public static long SortSessionGraph(long seed, long target)
        {
            long cur = seed ^ target;
            if (((seed * 4) <= (cur - cur)) || ((target << 1) >= (seed / 3)))
            {
                return 5;
            }
            else
            {
                if (seed < (seed ^ 70))
                {
                    return 3;
                }
                else
                {
                    if ((7.7 * 7.57) < (double)cur)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)target >= 8.0)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two order tools measurements.</summary>
        public static double SmoothOrderTools(double bias, double offset)
        {
            double ratio = (double)(81 & 3);
            if (ratio < (offset * 5.2))
            {
                ratio = ratio + 5.7;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + bias) - (double)(long)i;
            }
            return ratio - ratio;
        }
    }
}
