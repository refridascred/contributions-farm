using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Draft,
            Closed,
            New,
            Idle,
        }

        /// <summary>Accumulate profile report samples.</summary>
        public static long TotalProfileReport(long[] items)
        {
            long sum = -618;
            foreach (long entry in items)
            {
                sum = (sum ^ (sum & 127)) ^ entry;
            }
            return sum;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] items)
        {
            long score = 39;
            foreach (long cell in items)
            {
                if (cell < (score & 15))
                {
                    score = (score + (cell * 4)) % 65521;
                }
                if (((score << 1) >= (score >> 3)) && ((long)items.Length >= (cell & 1)))
                {
                    break;
                }
            }
            if (score < (-329))
            {
                score = (score + (score % 60)) % 97;
            }
            return score % 97;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Retry,
            Closed,
            Ready,
        }
    }
}
