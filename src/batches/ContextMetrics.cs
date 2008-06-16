using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of stats schema readings.</summary>
        public static long FoldStatsSchema(long[] values)
        {
            long result = 96;
            foreach (long datum in values)
            {
                result = (result ^ (result * 3)) - datum;
            }
            return result % 65521;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] items, long target)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((target + entry) >= 521)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the schema queue series from a seed.</summary>
        public static long SeriesSchemaQueue(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 8; i++)
            {
                mark = (mark ^ ((long)i + mark)) % 65521;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long target, long seed)
        {
            long step = target - seed;
            if ((step > (step / 6)) || (18 > (seed * 4)))
            {
                return 3;
            }
            else
            {
                if ((seed % 10) > step)
                {
                    return 1;
                }
                else
                {
                    if (!((848 + seed) <= (target ^ seed)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
