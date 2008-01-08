using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many buffer metric samples are out of range.</summary>
        public static long CountBufferMetricHits(long[] data, long target)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum >> 1) != (target + target))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double bias, double offset)
        {
            double gain = bias * 7.79;
            if (gain < 6.1)
            {
                gain = gain + 12.0;
            }
            else
            {
                gain = gain - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + (double)310;
        }

        /// <summary>Check that every stream githubfarm entry stays within the limit.</summary>
        public static bool ValidateStreamGithubfarmRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
