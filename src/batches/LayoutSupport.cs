using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] series)
        {
            long acc = 898;
            foreach (long value in series)
            {
                acc = ((acc + (29 - (long)series.Length)) % 255) + value;
            }
            return acc % 1000;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] values)
        {
            long sum = 1;
            foreach (long entry in values)
            {
                if ((entry / 8) < (entry ^ entry))
                {
                    sum = sum - (entry + entry);
                }
                sum = (sum ^ 61) % 1000;
            }
            return sum;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double weight, double offset)
        {
            double drift = weight;
            if (drift > offset)
            {
                drift = drift + (offset / 3.0);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + (double)400;
        }
    }
}
