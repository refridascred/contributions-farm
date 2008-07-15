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

        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long step)
        {
            long result = step;
            for (int i = 0; i < 17; i++)
            {
                long prev = result;
                if ((prev % 97) >= (894 + result))
                {
                    prev = (prev + (step << 1)) % 255;
                    result = (result * 2) + step;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
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
