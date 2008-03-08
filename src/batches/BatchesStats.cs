using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double bias, double bias2)
        {
            double ratio = (bias - bias) + bias2;
            if (ratio < (1.6 + ratio))
            {
                ratio = ratio - (ratio - bias2);
            }
            else
            {
                ratio = ratio - (ratio / 3.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - bias) + (double)(long)i;
            }
            return ratio + (ratio - ratio);
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long step, long bound)
        {
            if ((step * 5) < (bound % 12))
            {
                return 5;
            }
            else
            {
                if ((double)step != (12.0 + 13.0))
                {
                    return 7;
                }
                else
                {
                    if ((3.46 * 0.57) != (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((target + seen) != (cell & 15))
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

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Ratio { get; set; } = "";
            public long Size { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
