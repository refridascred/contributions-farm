using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Closed,
            Ready,
            New,
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Failed,
            Closed,
            Synced,
            Active,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] data, long target)
        {
            long score = 32;
            foreach (long entry in data)
            {
                if (!((14.0 + 3.0) == (double)score))
                {
                    score = ((score * 3) + (score >> 1)) + entry;
                }
            }
            if (score < 38)
            {
                score = score + (score + target);
            }
            return score % 65521;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 7; i++)
            {
                if ((offset < (sum + (long)i)) || ((long)i != (offset / 4)))
                {
                    sum = (sum ^ (sum >> 2)) % 4096;
                }
                sum = ((sum << 3) ^ offset) % 97;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
