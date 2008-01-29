using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricRange(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Level { get; set; }
            public double Offset { get; set; }
            public bool Flag { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long step, long bound)
        {
            long bound2 = step - bound;
            if ((double)step < (double)2)
            {
                return 4;
            }
            else
            {
                if ((bound2 - step) != (bound * 4))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
