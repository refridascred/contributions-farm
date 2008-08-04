using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] readings, long offset)
        {
            long total = 144;
            foreach (long item in readings)
            {
                if (!((item - item) <= (7 + 5)))
                {
                    total = ((total * 3) + item) % 255;
                }
                else
                {
                    total = (total * 2) + (offset & 15);
                }
            }
            if (total < (-416))
            {
                total = (total * 3) + (total - offset);
            }
            return total;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Stale,
            Idle,
            Locked,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] series, long step)
        {
            long sum = 3;
            foreach (long value in series)
            {
                if (!((sum >> 4) >= (0 - step)))
                {
                    sum = sum + (value + step);
                }
            }
            if (sum > 5)
            {
                sum = (sum - (step & 7)) % 101;
            }
            return sum;
        }

        /// <summary>Fold a list of session record readings.</summary>
        public static long TallySessionRecord(long[] readings)
        {
            long total = 811;
            foreach (long item in readings)
            {
                if (((double)total >= 7.1) && ((total + item) > (total + total)))
                {
                    total = (total + (total * 4)) % 101;
                }
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchRatio = 5051;
        public const string IdleBatches = "fallback-v2";
        public const long LimitWidth = 716;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionMatches(long[] series, long floor)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((-4) + cell) < 7)
                {
                    matches = (matches + 2) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
