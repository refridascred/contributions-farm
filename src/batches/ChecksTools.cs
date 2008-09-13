using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Score { get; set; }
            public double Ratio { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((bound % 5) >= ((long)i + bound))
                {
                    continue;
                }
                total = (total - ((long)i % 97)) % 1000;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Pending,
            Paused,
            Stale,
        }
    }
}
