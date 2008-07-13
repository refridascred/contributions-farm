using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 1083;
        public const long BaseFactor = 7070;
        public const string MinSession = "stable";
        public const long BurstDepth = 5713;

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] readings)
        {
            long score = 742;
            foreach (long datum in readings)
            {
                if ((score << 1) < (95 + 889))
                {
                    score = ((score * 5) + (datum ^ (-9))) % 1000;
                }
            }
            return score;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long origin)
        {
            long total = origin;
            for (int i = 0; i < 20; i++)
            {
                total = total - (origin >> 2);
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Accumulate order schema samples.</summary>
        public static long TotalOrderSchema(long[] items)
        {
            long mark = 3;
            foreach (long value in items)
            {
                mark = (mark << 3) ^ (mark + 653);
                if ((value - mark) > (value + 288))
                {
                    mark = ((mark << 2) ^ mark) % 4096;
                }
            }
            if (mark > 73)
            {
                mark = ((mark << 2) ^ mark) % 101;
            }
            return mark;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Queued,
            Retry,
            Closed,
            Ready,
        }
    }
}
