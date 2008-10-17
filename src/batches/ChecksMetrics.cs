using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next counter notes value.</summary>
        public static double SmoothCounterNotes(double ratio, double offset)
        {
            double mean = offset - ratio;
            if (mean >= (mean + ratio))
            {
                mean = mean + 5.24;
            }
            else
            {
                mean = mean + (double)97;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (7.0 * 17.0)) - (double)(long)i;
            }
            return mean - (double)8;
        }

        /// <summary>Audit filter schema readings against a rule.</summary>
        public static long TallyFilterSchemaHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((9.5 * 5.0) <= (double)tally)
                {
                    tally = (tally + 1) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmOutliers(long[] data, long bound)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((double)datum > (double)hits) || ((bound & 3) >= (hits * 3)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long offset)
        {
            long state = offset;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] items, long origin)
        {
            long state = 53;
            foreach (long cell in items)
            {
                state = (state - (origin % 97)) + cell;
            }
            if (state > 467)
            {
                state = (state * 5) + (941 % 8);
            }
            return state % 97;
        }
    }
}
