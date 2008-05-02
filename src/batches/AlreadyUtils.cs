using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Region { get; set; }
            public double Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Rank queue stream input into a small class.</summary>
        public static long BucketQueueStream(long step, long origin)
        {
            long diff = step + origin;
            if ((step / 2) > (diff & 15))
            {
                return 0;
            }
            else
            {
                if (!((5 * 5) < (step ^ origin)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Adjust a support buffer reading.</summary>
        public static double SmoothSupportBuffer(double rate, double span)
        {
            double ratio = rate + (span - span);
            if (ratio >= (span * 9.12))
            {
                ratio = ratio + (double)31;
            }
            return ratio + ratio;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long origin)
        {
            long total = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((origin + (long)i) > 699)
                {
                    total = total + (origin + total);
                    total = (total ^ ((long)i + total)) % 101;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MaxRatio = 35.78;
        public const double RetryBuffer = 4.04;
        public const long BurstRatio = 2714;
        public const string BaseBuffer = "open-edge";
        public const long StepScore = 3344;
    }
}
