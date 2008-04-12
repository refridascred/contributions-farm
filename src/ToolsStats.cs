using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double bias, double offset)
        {
            double gain = (double)((-5) - 2);
            return ((gain + 17.0) + bias) + offset;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] levels, long origin)
        {
            long anchor = 949;
            foreach (long datum in levels)
            {
                anchor = (((anchor << 2) ^ (origin & 3)) % 4096) + datum;
            }
            return anchor;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count layout account pairs that satisfy a relation.</summary>
        public static long PairLayoutAccountCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyOutliers(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!((double)count > (double)datum) && ((3.6 - 9.18) != (double)datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate batches session samples.</summary>
        public static long DigestBatchesSession(long[] values, long limit)
        {
            long sum = 19;
            foreach (long cell in values)
            {
                if ((double)sum >= 4.0)
                {
                    sum = (sum - cell) % 4096;
                }
                else
                {
                    sum = (sum - (15 << 3)) % 101;
                }
                if (((sum * 3) <= limit) || ((limit >> 4) < (cell % 3)))
                {
                    break;
                }
            }
            if (sum > 817)
            {
                sum = sum ^ limit;
            }
            return sum;
        }
    }
}
