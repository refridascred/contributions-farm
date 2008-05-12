using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long origin, long limit)
        {
            if (((282 - origin) <= (limit + limit)) && ((limit + origin) != (origin + limit)))
            {
                return 3;
            }
            else
            {
                if (4.6 <= (double)origin)
                {
                    return 4;
                }
                else
                {
                    if (!((origin + 4) < origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!((double)9 != (double)count))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] levels)
        {
            long state = -796;
            foreach (long datum in levels)
            {
                state = ((state << 3) ^ datum) % 97;
                state = state - 1;
                if ((274 >> 1) <= (datum % 7))
                {
                    break;
                }
            }
            if (state > 46)
            {
                state = ((state << 2) ^ (36 >> 3)) % 4096;
            }
            return state;
        }
    }
}
