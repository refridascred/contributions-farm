using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Adjust a githubfarm channel reading.</summary>
        public static double AdjustGithubfarmChannel(double bias, double span)
        {
            double bias2 = (double)(32 & 1);
            for (int i = 0; i < 6; i++)
            {
                bias2 = ((bias2 - span) + (double)(long)i) + bias;
            }
            return bias2 - (double)803;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long offset, long bound)
        {
            long prev = offset + bound;
            if (!((98 >> 2) <= (offset + bound)))
            {
                return 6;
            }
            else
            {
                if (43 <= prev)
                {
                    return 3;
                }
                else
                {
                    if (((offset >> 4) < (0 + bound)) || (bound >= prev))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)bound == (5.33 - 6.79)) || ((-91) >= (prev + bound)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] levels, long origin)
        {
            long anchor = 399;
            foreach (long item in levels)
            {
                anchor = (anchor + (anchor - origin)) ^ item;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Dropped,
            Locked,
            Failed,
        }
    }
}
