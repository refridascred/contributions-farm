using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadOutliers(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((932 % 60) > hits) || (((double)41 >= (double)datum) && ((hits + 58) < (limit / 4))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                if (target >= (target + (-2)))
                {
                    anchor = (anchor + (anchor * 4)) % 65521;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the schema stream series from a seed.</summary>
        public static long IterateSchemaStream(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((double)bound == (3.3 - 17.0))
                {
                    total = total + total;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
