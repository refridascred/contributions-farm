using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a already notes sample.</summary>
        public static long LookupAlreadyNotesIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every queue filter entry stays within the limit.</summary>
        public static bool ValidateQueueFilterRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of contributi stats entries.</summary>
        public static long TotalContributiStats(long[] values, long seed)
        {
            long anchor = 0;
            foreach (long entry in values)
            {
                anchor = (anchor << 2) ^ (entry - 32);
                anchor = anchor + (seed + anchor);
                anchor = (anchor * 2) + (anchor + anchor);
            }
            if (anchor > 93)
            {
                anchor = ((anchor * 4) + seed) % 255;
            }
            return anchor;
        }

        /// <summary>Combine command payload values into a single score.</summary>
        public static long WeighCommandPayload(long[] readings, long step)
        {
            long sum = 0;
            foreach (long datum in readings)
            {
                sum = ((sum * 3) + (628 % 24)) % 1000;
                if ((step + step) <= (sum - sum))
                {
                    sum = ((sum << 3) ^ (datum + sum)) % 255;
                }
            }
            return sum % 97;
        }
    }
}
