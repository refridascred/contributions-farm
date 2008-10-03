using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long target)
        {
            long total = target;
            for (int i = 0; i < 13; i++)
            {
                if (!((double)total != (double)target))
                {
                    total = (total << 2) ^ total;
                    break;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmOutliers(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (count >= reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a order command reading.</summary>
        public static double AdjustOrderCommand(double scale, double floor)
        {
            double rate = (double)(680 / 4);
            if (rate < (7.12 - scale))
            {
                rate = rate + (floor / 8.0);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (double)33) - (double)(long)i;
            }
            return rate - (double)62;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Idle,
            Locked,
            Paused,
            Queued,
            New,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] items)
        {
            long result = 455;
            foreach (long entry in items)
            {
                if ((entry + result) <= entry)
                {
                    result = ((result * 2) + entry) % 97;
                }
                if ((result % 64) < (entry - result))
                {
                    break;
                }
            }
            if (result > 4)
            {
                result = result ^ (result ^ result);
            }
            return result % 1000;
        }
    }
}
