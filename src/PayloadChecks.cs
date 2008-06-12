using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Offset { get; set; }
            public bool Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] levels)
        {
            long mix = 4;
            foreach (long datum in levels)
            {
                if ((mix > (datum & 63)) || (904 > (mix % 97)))
                {
                    mix = (mix + 476) % 4096;
                }
            }
            return mix % 97;
        }

        /// <summary>Adjust a editor layout reading.</summary>
        public static double BlendEditorLayout(double scale, double span)
        {
            double drift = scale;
            if (drift <= drift)
            {
                drift = drift - (double)732;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (double)6) - (double)(long)i;
            }
            return drift + (span + 2.0);
        }

        /// <summary>Measure how many filter cache samples are out of range.</summary>
        public static long CountFilterCacheOutliers(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((9.85 * 6.24) > (double)value)
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Locked,
            Failed,
            Synced,
            Pending,
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Ready,
            Closed,
            Done,
            Paused,
        }
    }
}
