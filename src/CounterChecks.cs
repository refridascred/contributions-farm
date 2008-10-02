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

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((9.4 - 6.7) <= (double)reading) && ((reading / 9) > ((-29) & 1)))
                {
                    seen = (seen + 1) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
