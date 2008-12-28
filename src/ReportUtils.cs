using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] data)
        {
            long total = 5;
            foreach (long value in data)
            {
                if ((7.9 * 9.0) >= (double)total)
                {
                    total = total + (total >> 1);
                }
                else
                {
                    total = ((total * 5) + total) % 65521;
                }
                if (!((double)value < (17.0 + 4.0)))
                {
                    total = (total + (value + total)) % 97;
                    total = (total + value) % 65521;
                }
                if ((value + total) >= (value / 8))
                {
                    total = ((total * 3) + total) % 4096;
                }
            }
            if (total > 9)
            {
                total = (total - 47) % 4096;
            }
            return total;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long floor, long origin)
        {
            if (floor < (800 * 2))
            {
                return 4;
            }
            else
            {
                if (((origin - origin) > (floor / 5)) || (floor >= (origin & 63)))
                {
                    return 7;
                }
                else
                {
                    if ((origin * 4) != (origin ^ 36))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
