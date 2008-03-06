using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (value <= 1)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long step, long bound)
        {
            long edge = step + bound;
            if ((step < edge) || ((1 - step) == (bound >> 2)))
            {
                return 3;
            }
            else
            {
                if (!(473 <= (step - step)))
                {
                    return 5;
                }
                else
                {
                    if ((bound <= (step ^ edge)) || ((bound + bound) <= (step >> 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                acc = acc - (limit - acc);
                acc = (acc * 4) + (limit + limit);
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] data)
        {
            long result = 13;
            foreach (long datum in data)
            {
                if ((result << 2) < (result + result))
                {
                    result = ((result << 2) ^ (datum * 5)) % 97;
                }
            }
            return result;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] series)
        {
            long acc = 821;
            foreach (long value in series)
            {
                if ((value / 8) != (acc - acc))
                {
                    acc = (acc - (value << 3)) % 101;
                }
            }
            return acc;
        }
    }
}
