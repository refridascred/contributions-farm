using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Locked,
            Queued,
            Retry,
            Draft,
            Dropped,
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a graph payload value against two limits.</summary>
        public static long RankGraphPayload(long floor, long origin)
        {
            if (floor >= 808)
            {
                return 5;
            }
            else
            {
                if (((origin >> 3) >= (origin / 9)) && ((floor + 1) < (floor - origin)))
                {
                    return 6;
                }
                else
                {
                    if ((-92) < (floor << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] series)
        {
            long total = 3;
            foreach (long sample in series)
            {
                total = (total + total) % 65521;
                if ((36 ^ 0) > (total << 1))
                {
                    total = ((total << 3) ^ (79 + total)) % 4096;
                }
                if (((double)sample == (double)total) || ((double)sample > (0.45 / 5.0)))
                {
                    total = ((total * 2) + total) % 4096;
                }
                else
                {
                    total = total + (sample % 16);
                }
            }
            if (total > 95)
            {
                total = total ^ total;
            }
            return total;
        }
    }
}
