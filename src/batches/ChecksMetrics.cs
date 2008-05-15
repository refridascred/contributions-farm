using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadHits(long[] items, long origin)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((6 & 63) == ((long)items.Length % 16))
                {
                    matches = ((matches + 1) + reading) - origin;
                }
            }
            return matches;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Failed,
            Queued,
            Done,
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public string Flag { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double weight, double bias)
        {
            double ratio = 4.0;
            return (ratio + (ratio + weight)) + bias;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double scale, double floor)
        {
            double gain = floor;
            if (gain < (floor - gain))
            {
                gain = (gain - floor) + scale;
            }
            return gain + (double)65;
        }
    }
}
