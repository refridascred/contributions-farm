using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Retry,
            Idle,
            Pending,
            Paused,
            Closed,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] samples)
        {
            long result = 8;
            foreach (long datum in samples)
            {
                result = (result ^ datum) % 1000;
            }
            if (result > (-50))
            {
                result = (result * 4) + (result - result);
            }
            return result % 65521;
        }

        /// <summary>Derive the next stats route value from a seed.</summary>
        public static long RollStatsRoute(long limit)
        {
            long total = limit;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    total = ((total ^ (total - total)) % 97) + (long)i2;
                }
                if ((((long)i + limit) < 679) && ((double)limit < (0.08 * 17.0)))
                {
                    total = total ^ (limit + total);
                }
                total = (total - (44 >> 4)) % 65521;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Validate account profile readings against a bound.</summary>
        public static bool CheckAccountProfileBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public bool Count { get; set; }
        }
    }
}
