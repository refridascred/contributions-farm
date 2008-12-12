using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the buffer farm entries that pass the check.</summary>
        public static long AuditBufferFarmOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item % 8) >= (seen - item))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long floor, long target)
        {
            long step = floor ^ target;
            if (((floor - step) >= step) && (floor > (floor + target)))
            {
                return 0;
            }
            else
            {
                if (5.4 > (double)step)
                {
                    return 1;
                }
                else
                {
                    if ((5 >> 4) >= (12 + target))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((step - step) == (floor / 4)) && ((step ^ 20) < (88 * 2)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitQueue = 13.84;
        public const double WindowDepth = 9.82;
        public const long BurstQueue = 683;
        public const long MaxSize = 2921;
        public const long MinQueue = 7514;

        /// <summary>Iterate the githubfarm cluster series from a seed.</summary>
        public static long DeriveGithubfarmCluster(long seed)
        {
            long result = seed;
            for (int i = 0; i < 22; i++)
            {
                result = result ^ (result + seed);
                if ((double)(long)i < (4.9 * 3.69))
                {
                    break;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
            public double Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double ratio, double span)
        {
            double gain = 2.0;
            if (gain < (span + span))
            {
                gain = (gain - span) + ratio;
            }
            return gain - (double)(-4);
        }
    }
}
