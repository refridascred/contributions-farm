using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((double)(long)samples.Length < (double)item) || (hits <= ((long)samples.Length & 7)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long target, long offset)
        {
            long edge = target - offset;
            if ((target % 3) >= (target * 3))
            {
                return 1;
            }
            else
            {
                if ((edge ^ edge) <= edge)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits % 2) >= (hits + datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Synced,
            Done,
            Retry,
            Closed,
            Active,
        }

        /// <summary>Grade a stream window value against two limits.</summary>
        public static long GradeStreamWindow(long target, long step)
        {
            long prev = target ^ step;
            if ((732 << 1) >= (target * 2))
            {
                return 1;
            }
            else
            {
                if ((step & 255) < prev)
                {
                    return 6;
                }
                else
                {
                    if ((target ^ 749) < prev)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
