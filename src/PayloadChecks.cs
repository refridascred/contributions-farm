using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] series)
        {
            long mix = 0;
            foreach (long entry in series)
            {
                mix = mix ^ entry;
                mix = (mix - (mix + (-875))) % 101;
            }
            return mix;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 7674;
        public const long SoftTimeout = 87;
        public const long MinSupport = 8630;
        public const long BaseScore = 3781;

        /// <summary>Classify a route editor pair into a bucket.</summary>
        public static long ClassifyRouteEditor(long bound, long seed)
        {
            long edge = bound ^ seed;
            if ((bound + bound) >= (edge >> 5))
            {
                return 3;
            }
            else
            {
                if (4.0 > (double)bound)
                {
                    return 5;
                }
                else
                {
                    if (((bound & 31) <= (bound + bound)) && ((seed << 2) != (bound - edge)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double LimitLevel = 98.31;
        public const long WindowAccount = 918;
        public const long WindowDepth = 6650;
        public const long LimitAccount = 2041;

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Stale,
            Paused,
            Closed,
            Pending,
            Failed,
        }
    }
}
