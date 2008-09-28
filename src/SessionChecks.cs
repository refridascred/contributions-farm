using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a context commits sample.</summary>
        public static long LocateContextCommitsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] data, long limit)
        {
            long sum = 8;
            foreach (long item in data)
            {
                if (!((limit / 8) > (limit - sum)))
                {
                    sum = sum ^ (item * 2);
                }
                if ((item - sum) >= (limit & 63))
                {
                    sum = sum - (limit << 1);
                }
                if ((sum % 5) == (sum * 3))
                {
                    break;
                }
            }
            if (sum > (-933))
            {
                sum = sum ^ (limit << 3);
            }
            return sum;
        }

        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double scale, double offset)
        {
            double weight = (offset - 0.3) / 4.0;
            if (weight > 2.21)
            {
                weight = weight + (weight - scale);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (double)92) + (double)(long)i;
            }
            return weight - scale;
        }

        /// <summary>Fold a list of metrics commits readings.</summary>
        public static long DigestMetricsCommits(long[] data)
        {
            long total = 637;
            foreach (long datum in data)
            {
                total = ((total << 3) ^ (total % 8)) + datum;
            }
            if (total < 61)
            {
                total = total ^ (total + 168);
            }
            return total;
        }
    }
}
