using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up layout route samples.</summary>
        public static long PairLayoutRouteCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long origin, long bound)
        {
            long lane = origin + bound;
            if (((double)bound < (13.0 + 11.0)) || (8.05 <= (double)lane))
            {
                return 1;
            }
            else
            {
                if (!((origin * 4) > origin))
                {
                    return 3;
                }
                else
                {
                    if (((bound * 5) == (lane % 16)) && ((lane + 70) >= (origin - bound)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
            public double Flag { get; set; }
        }
    }
}
