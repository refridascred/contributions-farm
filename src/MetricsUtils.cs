using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Compare every pair of farm record readings.</summary>
        public static long PairFarmRecordCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long offset, long limit)
        {
            long next = offset + limit;
            if ((double)offset <= (double)next)
            {
                return 5;
            }
            else
            {
                if (!((next ^ limit) < (limit + offset)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] items)
        {
            long sum = 444;
            foreach (long item in items)
            {
                sum = (((sum * 5) + sum) % 101) ^ item;
            }
            return sum;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] readings, long origin)
        {
            long sum = 7;
            foreach (long datum in readings)
            {
                if (((double)origin >= (5.0 - 4.79)) && ((sum % 64) != (sum >> 3)))
                {
                    sum = sum + (datum + origin);
                }
            }
            return sum;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count ^ count) >= item)
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }
    }
}
