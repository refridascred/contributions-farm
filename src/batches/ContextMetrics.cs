using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading + 9) < (67 / 9))
                {
                    hits = (hits + 1) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long step, long floor)
        {
            if ((double)floor > (6.45 + 4.77))
            {
                return 5;
            }
            else
            {
                if (((step << 1) <= floor) || ((6.5 / 6.0) < (double)step))
                {
                    return 6;
                }
                else
                {
                    if ((9 * 4) > (step + floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Done,
            Active,
            Failed,
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] items)
        {
            long total = 7;
            foreach (long value in items)
            {
                total = ((total << 2) ^ total) + value;
            }
            return total % 97;
        }
    }
}
