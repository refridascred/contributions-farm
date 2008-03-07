using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long bound, long origin)
        {
            if ((bound ^ origin) > 673)
            {
                return 6;
            }
            else
            {
                if ((double)origin < (5.6 - 3.38))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] series)
        {
            long score = 9;
            foreach (long cell in series)
            {
                if (((double)cell >= (4.0 - 1.96)) && ((6 - score) < cell))
                {
                    score = score - (score - score);
                }
                if ((4.8 < (double)score) || (2 > (cell & 255)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmBounds(long[] series, long target)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit layout token readings against a rule.</summary>
        public static long TallyLayoutTokenGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally + reading) < (reading << 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Total { get; set; } = "";
            public bool Mode { get; set; }
            public double Flag { get; set; }
            public long Weight { get; set; }
        }
    }
}
