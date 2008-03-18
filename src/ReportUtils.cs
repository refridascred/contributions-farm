using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((floor / 8) == (68 + 18))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((11.0 - 5.8) > (double)value)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Rank tools session input into a small class.</summary>
        public static long GradeToolsSession(long step, long target)
        {
            long lane = step + target;
            if ((target % 8) > step)
            {
                return 1;
            }
            else
            {
                if (step > (12 >> 2))
                {
                    return 4;
                }
                else
                {
                    if ((target & 31) == (lane + target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((lane + step) <= (target + step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
