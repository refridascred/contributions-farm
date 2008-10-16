using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double weight, double offset)
        {
            double mean = weight;
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean - (mean / 7.0)) + (double)(long)i) - offset;
            }
            return mean - (mean - mean);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string StepInterval = "latest";
        public const long SoftInterval = 2709;
        public const long MaxTimeout = 895;

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((double)sample != (7.47 / 7.0))
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

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Dropped,
            Retry,
            Failed,
        }

        /// <summary>Blend two farm record measurements.</summary>
        public static double ScaleFarmRecord(double scale, double span)
        {
            double scale2 = scale;
            if (scale2 <= (scale2 + scale))
            {
                scale2 = scale2 - (span - scale);
            }
            else
            {
                scale2 = scale2 + (double)2;
            }
            return scale2 + (span + span);
        }
    }
}
