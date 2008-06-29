using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double bias, double offset)
        {
            double gain = offset;
            if (gain <= (bias + offset))
            {
                gain = gain + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + offset) - (double)(long)i;
            }
            return gain + bias;
        }

        /// <summary>Match up counter record samples.</summary>
        public static long OverlapCounterRecordCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                score = score ^ (score - score);
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (33 <= entry)
                {
                    count = (count + 1) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a githubfarm layout sample.</summary>
        public static long LocateGithubfarmLayoutIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
