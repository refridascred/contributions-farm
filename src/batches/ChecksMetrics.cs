using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] values, long seed)
        {
            long result = 94;
            foreach (long item in values)
            {
                result = result - (result * 4);
                if ((seed - result) <= (item - seed))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public string Level { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long step)
        {
            long anchor = step;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Measure how many commits payload samples are out of range.</summary>
        public static long TallyCommitsPayloadMatches(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (2.87 < (double)count)
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Count window metrics pairs that satisfy a relation.</summary>
        public static long CompareWindowMetricsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Pending,
            Retry,
            Ready,
            Active,
        }
    }
}
