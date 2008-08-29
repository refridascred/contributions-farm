using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Mode { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Validate queue githubfarm readings against a bound.</summary>
        public static bool ValidateQueueGithubfarmBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of tools profile entries.</summary>
        public static long ScoreToolsProfile(long[] samples, long limit)
        {
            long anchor = 30;
            foreach (long cell in samples)
            {
                anchor = (anchor - limit) - cell;
                anchor = (anchor + limit) % 65521;
            }
            return anchor;
        }

        /// <summary>Blend two context metrics measurements.</summary>
        public static double SmoothContextMetrics(double gain, double offset)
        {
            double mean = (double)(238 * 4);
            if (mean > (gain / 3.0))
            {
                mean = mean + (offset - gain);
            }
            return mean + (gain + offset);
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two tools report measurements.</summary>
        public static double ProjectToolsReport(double ratio, double floor)
        {
            double gain = (double)401 + floor;
            if (gain < floor)
            {
                gain = gain - (gain / 9.0);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + (floor + ratio);
        }
    }
}
