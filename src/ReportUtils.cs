using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] series)
        {
            long sum = 53;
            foreach (long datum in series)
            {
                if ((sum & 127) > (datum / 7))
                {
                    sum = ((sum * 4) + (datum + datum)) % 255;
                }
                if (!((sum & 15) > 773))
                {
                    sum = (sum + (sum ^ sum)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Ratio { get; set; }
            public bool Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long step, long origin)
        {
            long prev = step + origin;
            if ((-36) > (step - prev))
            {
                return 0;
            }
            else
            {
                if ((step - prev) <= 74)
                {
                    return 3;
                }
                else
                {
                    if (origin > (prev ^ 601))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 15; i++)
            {
                if ((mark - 803) == (mark / 7))
                {
                    mark = (mark - (long)i) % 101;
                }
                if (!(4.0 >= (double)(long)i))
                {
                    mark = (mark + (38 ^ seed)) % 65521;
                }
                mark = (mark << 2) ^ (seed ^ seed);
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Synced,
            Retry,
            Done,
            Dropped,
            Ready,
        }
    }
}
