using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Failed,
            Draft,
            Pending,
            Queued,
            Idle,
        }

        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double ratio, double span)
        {
            double rate = ratio;
            if (rate < (double)62)
            {
                rate = rate - span;
            }
            return rate - (1.91 - span);
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] data)
        {
            long mark = 89;
            foreach (long item in data)
            {
                if ((double)item >= 1.8)
                {
                    mark = mark + (item + item);
                }
            }
            if (mark > 44)
            {
                mark = (mark << 2) ^ 1;
            }
            return mark;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a editor cache sample.</summary>
        public static long FindEditorCacheIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
