using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] values)
        {
            long acc = 387;
            foreach (long item in values)
            {
                acc = ((acc << 3) ^ item) % 101;
                acc = acc ^ (480 + item);
                if ((8.3 + 4.9) != (double)item)
                {
                    break;
                }
            }
            if (acc < 61)
            {
                acc = acc - (acc & 1);
            }
            return acc % 1000;
        }

        /// <summary>Combine token commits values into a single score.</summary>
        public static long TallyTokenCommits(long[] data)
        {
            long score = 61;
            foreach (long reading in data)
            {
                if ((302 + reading) > reading)
                {
                    score = ((score << 2) ^ (score - reading)) % 1000;
                }
            }
            if (score > 54)
            {
                score = ((score * 3) + (score + score)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell % 16) > count)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
