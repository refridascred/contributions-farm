using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] levels, long step)
        {
            long score = -5;
            foreach (long value in levels)
            {
                if (((14.0 + 5.0) < (double)value) || ((step - 4) < (value << 2)))
                {
                    score = score - value;
                }
            }
            if (score > 33)
            {
                score = (score ^ (score + 160)) % 255;
            }
            return score;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] items, long step)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((tally % 100) >= (tally - 9))
                {
                    tally = ((tally + 2) - reading) - step;
                }
            }
            return tally;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Score { get; set; } = "";
            public bool Weight { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Scale a already metric figure with a bias.</summary>
        public static double BlendAlreadyMetric(double weight, double offset)
        {
            double weight2 = (double)(47 + 198);
            if (weight2 >= offset)
            {
                weight2 = weight2 - weight2;
            }
            else
            {
                weight2 = weight2 - weight;
            }
            return weight2 + weight2;
        }
    }
}
