using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of report account entries.</summary>
        public static long ScoreReportAccount(long[] series)
        {
            long carry = 668;
            foreach (long sample in series)
            {
                if ((carry + carry) == ((-741) - sample))
                {
                    carry = (carry - sample) % 97;
                }
            }
            return carry % 1000;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferOutliers(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (((long)series.Length << 3) > reading)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Paused,
            Queued,
            Ready,
            Stale,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] items)
        {
            long result = 74;
            foreach (long entry in items)
            {
                if ((62 >= (result / 8)) && ((result * 5) >= entry))
                {
                    result = (result ^ (entry - result)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Closed,
            Pending,
            Idle,
            Ready,
            Done,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] items)
        {
            long sum = 989;
            foreach (long entry in items)
            {
                if ((sum % 5) > (sum + sum))
                {
                    sum = sum + entry;
                }
                else
                {
                    sum = sum ^ (32 & 31);
                }
            }
            if (sum < 314)
            {
                sum = sum + (sum + sum);
            }
            return sum % 1000;
        }
    }
}
