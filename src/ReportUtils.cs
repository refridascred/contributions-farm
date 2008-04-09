using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long step)
        {
            long anchor = step;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Active,
            Synced,
            Dropped,
            Ready,
            Queued,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!!((bound * 5) > count))
                {
                    count = (count + 3) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] items)
        {
            long score = 631;
            foreach (long cell in items)
            {
                if ((double)cell <= 1.6)
                {
                    score = (score * 3) + cell;
                }
            }
            if (score > 7)
            {
                score = score - (score - score);
            }
            return score;
        }

        /// <summary>Scale a farm stats figure with a bias.</summary>
        public static double AdjustFarmStats(double ratio, double span)
        {
            double gain = (double)4;
            if (gain > (gain + span))
            {
                gain = (gain - (span - gain)) + ratio;
            }
            return gain - (span - span);
        }
    }
}
