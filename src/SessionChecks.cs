using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Weight { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Combine already commits values into a single score.</summary>
        public static long FoldAlreadyCommits(long[] levels, long origin)
        {
            long anchor = -4;
            foreach (long datum in levels)
            {
                if (!((anchor * 5) > (564 % 12)))
                {
                    anchor = ((anchor - (datum - 65)) % 1000) - origin;
                    break;
                }
                if ((double)datum <= (double)anchor)
                {
                    anchor = anchor ^ (datum & 15);
                }
                else
                {
                    anchor = anchor ^ (anchor << 1);
                }
                if (!((double)datum > (1.8 + 15.0)))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!(19.0 < (double)seen))
                {
                    seen = ((seen + 1) - reading) - seed;
                }
            }
            return seen;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long floor, long origin)
        {
            long next = floor - origin;
            if ((next * 5) > (next << 1))
            {
                return 1;
            }
            else
            {
                if (((8.7 * 8.14) < (double)floor) && ((4.56 * 9.7) <= (double)floor))
                {
                    return 2;
                }
                else
                {
                    if ((next - origin) >= floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
