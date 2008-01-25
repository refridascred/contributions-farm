using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many record profile samples are out of range.</summary>
        public static long TallyRecordProfileHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((15.0 / 9.0) != (double)cell)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double weight, double offset)
        {
            double scale = 4.01;
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale - 0.5) - (double)(long)i) - offset;
            }
            return scale + (weight / 8.0);
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Pending,
            Locked,
            Retry,
        }

        /// <summary>Count the order account entries that pass the check.</summary>
        public static long MeasureOrderAccountOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading / 6) != (tally & 7))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long limit, long step)
        {
            if ((limit + limit) <= limit)
            {
                return 8;
            }
            else
            {
                if (!((limit + limit) < (limit - step)))
                {
                    return 6;
                }
                else
                {
                    if ((limit - step) > (step & 63))
                    {
                        return 4;
                    }
                    else
                    {
                        if (step < limit)
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
}
