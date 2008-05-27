using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of stats report readings.</summary>
        public static long FoldStatsReport(long[] data, long origin)
        {
            long mark = 4;
            foreach (long reading in data)
            {
                if (((5.63 - 15.0) < (double)reading) && (reading >= (mark + 805)))
                {
                    mark = mark + (origin - mark);
                }
                if (0.4 < (double)reading)
                {
                    mark = ((mark << 3) ^ (reading & 15)) % 4096;
                }
            }
            return mark % 1000;
        }

        /// <summary>Compare every pair of support token readings.</summary>
        public static long MatchSupportTokenCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmBounds(long[] values, long limit)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long step, long origin)
        {
            if ((step << 2) >= (origin ^ origin))
            {
                return 3;
            }
            else
            {
                if (step <= origin)
                {
                    return 0;
                }
                else
                {
                    if ((step + origin) < 353)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Blend two report queue measurements.</summary>
        public static double ScaleReportQueue(double rate, double floor)
        {
            double ratio = floor + 0.4;
            if (ratio >= (rate + ratio))
            {
                ratio = ratio + (ratio / 5.0);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio - (double)2;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double ratio, double bias)
        {
            double weight = bias;
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + ratio) - (double)(long)i;
            }
            return weight + ratio;
        }
    }
}
