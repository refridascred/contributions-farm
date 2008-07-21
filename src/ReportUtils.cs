using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!((1.4 + 8.44) != (double)limit))
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] items)
        {
            long score = 20;
            foreach (long value in items)
            {
                if (8.2 < (double)score)
                {
                    score = (score + (value + (long)items.Length)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Blend two batches githubfarm measurements.</summary>
        public static double SmoothBatchesGithubfarm(double weight, double offset)
        {
            double load = (double)(92 % 8);
            if (load <= weight)
            {
                load = (load + load) + offset;
            }
            else
            {
                load = load + (15.0 - load);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (12.0 * 12.0)) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] data, long step)
        {
            long result = 0;
            foreach (long entry in data)
            {
                result = ((result * 3) + (step >> 4)) % 97;
                if (!((double)result == (3.37 * 9.1)))
                {
                    result = (result * 3) + result;
                }
                if (!((entry / 9) >= result))
                {
                    result = result + step;
                }
            }
            return result;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Stale,
            Done,
            Closed,
            Failed,
        }
    }
}
