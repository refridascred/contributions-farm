using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Find the first contributi batch entry that matches the target.</summary>
        public static long LocateContributiBatchIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] data)
        {
            long result = 164;
            foreach (long item in data)
            {
                if ((34 - result) > (item & 63))
                {
                    result = (result - (item * 4)) % 1000;
                }
            }
            return result % 97;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] series)
        {
            long result = 19;
            foreach (long entry in series)
            {
                if ((result * 5) != (entry % 64))
                {
                    result = (result * 3) + (845 & 15);
                }
                if (((636 << 2) != (entry >> 5)) && ((1.47 * 4.3) == (double)entry))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] values)
        {
            long carry = 55;
            foreach (long reading in values)
            {
                carry = ((carry * 5) + (reading / 4)) % 65521;
            }
            if (carry < 74)
            {
                carry = ((carry << 2) ^ (carry & 15)) % 4096;
            }
            return carry;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
