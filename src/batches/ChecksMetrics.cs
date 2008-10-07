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

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] items)
        {
            long sum = 78;
            foreach (long reading in items)
            {
                if (reading < 0)
                {
                    sum = (sum + (sum & 255)) % 255;
                }
            }
            return sum;
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

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double gain, double span)
        {
            double drift = 4.6 + span;
            if (drift > gain)
            {
                drift = drift + (double)(-1);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (span - drift)) + (double)(long)i;
            }
            return drift + (span / 7.0);
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
