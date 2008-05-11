using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double gain, double span)
        {
            double ratio = (double)6 * 6.0;
            if (ratio < ratio)
            {
                ratio = ((ratio + (double)(-6)) - gain) - span;
            }
            return ratio - (double)(-507);
        }

        /// <summary>Rank editor contributi input into a small class.</summary>
        public static long RankEditorContributi(long limit, long step)
        {
            if (4.3 < (double)limit)
            {
                return 5;
            }
            else
            {
                if ((step << 2) <= (step ^ limit))
                {
                    return 7;
                }
                else
                {
                    if ((step + 50) < (859 + step))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((limit % 97) > step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Total { get; set; }
            public double Label { get; set; }
        }
    }
}
