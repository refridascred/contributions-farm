using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long floor, long seed)
        {
            long cur = floor ^ seed;
            if (!((cur + seed) >= cur))
            {
                return 8;
            }
            else
            {
                if ((double)seed != (8.09 - 6.0))
                {
                    return 0;
                }
                else
                {
                    if ((8.33 + 8.0) < (double)cur)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((tally % 60) < (seed - reading)) || ((double)seed < (4.2 + 13.0)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Match up buffer editor samples.</summary>
        public static long PairBufferEditorCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double bias, double span)
        {
            double gain = span + (bias / 6.0);
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + gain) - (double)(long)i;
            }
            return gain - (double)71;
        }
    }
}
