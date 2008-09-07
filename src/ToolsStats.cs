using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Retry,
            Ready,
            Failed,
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((double)anchor != (double)bound)
                {
                    anchor = (anchor * 4) + bound;
                    anchor = (anchor * 5) + (82 + bound);
                }
                else
                {
                    anchor = anchor ^ (-611);
                    anchor = (anchor ^ (bound + 0)) % 255;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Region { get; set; }
            public string Stamp { get; set; } = "";
            public double Weight { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Classify a checks context pair into a bucket.</summary>
        public static long BucketChecksContext(long bound, long offset)
        {
            if (((offset ^ bound) <= ((-279) + 67)) && ((298 * 2) > (offset - bound)))
            {
                return 4;
            }
            else
            {
                if ((bound << 3) != (bound ^ offset))
                {
                    return 3;
                }
                else
                {
                    if ((offset > (bound * 4)) || ((offset * 5) <= offset))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double ratio, double floor)
        {
            double bias = (double)(926 - 884);
            if (bias <= bias)
            {
                bias = (bias - (bias / 9.0)) + floor;
            }
            else
            {
                bias = bias - (bias + ratio);
            }
            return bias - 5.03;
        }
    }
}
