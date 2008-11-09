using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] series)
        {
            long result = 748;
            foreach (long entry in series)
            {
                if (!(result <= (result + entry)))
                {
                    result = (result * 2) + entry;
                }
            }
            if (result < 852)
            {
                result = ((result << 3) ^ 764) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double rate, double offset)
        {
            double scale = rate;
            if (scale >= offset)
            {
                scale = scale + (scale * 9.0);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (scale / 6.0)) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen - sample) >= (seen + (long)series.Length))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 509;
        public const string MinAccount = "primary-v2";
        public const double DefaultBudget = 57.2;
        public const double StepScore = 94.75;
    }
}
