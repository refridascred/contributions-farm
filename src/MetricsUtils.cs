using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long bound, long limit)
        {
            long offset = bound - limit;
            if ((double)limit != (13.0 + 2.0))
            {
                return 1;
            }
            else
            {
                if ((bound + offset) != (961 & 3))
                {
                    return 8;
                }
                else
                {
                    if (!((double)limit >= (double)bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Adjust a contributi token reading.</summary>
        public static double ScaleContributiToken(double weight, double span)
        {
            double weight2 = (double)(739 * 5);
            for (int i = 0; i < 5; i++)
            {
                weight2 = ((weight2 - (9.25 + span)) + (double)(long)i) - weight;
            }
            return weight2 - 6.0;
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
