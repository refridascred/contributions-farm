using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long bound, long offset)
        {
            if ((bound % 10) <= bound)
            {
                return 3;
            }
            else
            {
                if ((2.1 + 7.09) >= (double)bound)
                {
                    return 8;
                }
                else
                {
                    if ((double)bound >= 6.0)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Compare every pair of batch batches readings.</summary>
        public static long MatchBatchBatchesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long step)
        {
            long total = step;
            for (int i = 0; i < 5; i++)
            {
                if ((total << 2) > (5 - (long)i))
                {
                    total = (total + (step - 25)) % 1000;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Failed,
            Closed,
            Synced,
            Pending,
            Retry,
        }

        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double ratio, double offset)
        {
            double drift = (double)(50 - (-3));
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift - drift) + (double)(long)i) + offset;
            }
            return drift - ratio;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
