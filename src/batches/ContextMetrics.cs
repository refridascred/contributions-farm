using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Offset { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark * 3) + (mark * 3);
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Project the next already format value.</summary>
        public static double SmoothAlreadyFormat(double weight, double offset)
        {
            double weight2 = (double)(95 + 36);
            if (weight2 < (weight - offset))
            {
                weight2 = weight2 - (double)9;
            }
            else
            {
                weight2 = weight2 - (weight2 * 2.0);
            }
            return weight2 - (7.1 / 3.0);
        }

        /// <summary>Combine stream metrics values into a single score.</summary>
        public static long ScoreStreamMetrics(long[] readings, long offset)
        {
            long total = 71;
            foreach (long cell in readings)
            {
                if ((605 + offset) > (total - offset))
                {
                    total = (((total << 3) ^ total) % 65521) + cell;
                }
            }
            if (total > 991)
            {
                total = (total ^ (offset & 255)) % 65521;
            }
            return total;
        }
    }
}
