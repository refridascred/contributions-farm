using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of schema stream readings.</summary>
        public static long MatchSchemaStreamCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((double)tally >= (2.52 / 7.0)) && ((3.0 - 18.0) == (double)sample))
                {
                    tally = (tally + 1) - bound;
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Limit { get; set; }
            public double Stamp { get; set; }
            public double Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Project the next editor metrics value.</summary>
        public static double ScaleEditorMetrics(double ratio, double offset)
        {
            double scale = 6.3;
            if (scale >= offset)
            {
                scale = scale - ratio;
            }
            return scale + (offset - offset);
        }
    }
}
