using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double ScaleGithubfarm(double ratio, double floor)
        {
            double scale = (double)(20 << 2);
            if (scale > (double)827)
            {
                scale = scale + (ratio * 1.38);
            }
            else
            {
                scale = scale + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + ratio) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long step, long offset)
        {
            long edge = step - offset;
            if (18 <= edge)
            {
                return 8;
            }
            else
            {
                if ((9.4 * 20.0) > (double)offset)
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
}
