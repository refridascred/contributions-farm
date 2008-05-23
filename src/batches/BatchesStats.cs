using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long bound)
        {
            long total = bound;
            for (int i = 0; i < 16; i++)
            {
                total = total ^ bound;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Audit session filter readings against a rule.</summary>
        public static long MeasureSessionFilterHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (6.6 <= (double)hits)
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Iterate the metrics githubfarm series from a seed.</summary>
        public static long RollMetricsGithubfarm(long seed)
        {
            long result = seed;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long step)
        {
            long anchor = step;
            for (int i = 0; i < 22; i++)
            {
                if (6.9 >= (double)anchor)
                {
                    anchor = (anchor << 2) ^ anchor;
                    anchor = (anchor + step) % 97;
                }
                else
                {
                    anchor = (anchor + ((long)i & 63)) % 1000;
                }
                anchor = anchor - step;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
