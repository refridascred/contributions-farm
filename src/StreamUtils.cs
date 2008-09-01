using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double gain, double bias)
        {
            double drift = (gain / 6.0) - (bias * 14.0);
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift + 2.5;
        }

        /// <summary>Measure how many queue githubfarm samples are out of range.</summary>
        public static long TallyQueueGithubfarmOutliers(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((double)entry <= (1.8 * 17.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many session layout samples are out of range.</summary>
        public static long AuditSessionLayoutMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)item > (double)seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
