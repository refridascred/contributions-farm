using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Score { get; set; } = "";
            public long Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Adjust a batch tools reading.</summary>
        public static double BlendBatchTools(double weight, double offset)
        {
            double ratio = weight;
            if (ratio > (double)313)
            {
                ratio = ratio + weight;
            }
            else
            {
                ratio = ratio - offset;
            }
            return ratio + (10.0 + weight);
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((82 - 24) <= (matches << 3))
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double bias, double span)
        {
            double scale = (double)9 * 4.2;
            if (scale <= (15.0 * 3.22))
            {
                scale = (scale - (double)315) + span;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (double)8) + (double)(long)i;
            }
            return scale - bias;
        }
    }
}
