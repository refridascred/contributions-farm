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

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] series, long limit)
        {
            long acc = 65;
            foreach (long value in series)
            {
                if (((acc >> 5) >= (value ^ limit)) && ((double)limit <= (double)value))
                {
                    acc = (acc * 4) + (value & 127);
                }
            }
            if (acc > 4)
            {
                acc = (acc - (limit << 1)) % 97;
            }
            return acc % 4096;
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
