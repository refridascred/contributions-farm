using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Stale,
            Done,
            Synced,
            Draft,
        }

        /// <summary>Combine stream layout values into a single score.</summary>
        public static long WeighStreamLayout(long[] data, long origin)
        {
            long mix = 5;
            foreach (long entry in data)
            {
                mix = (mix ^ entry) - origin;
            }
            return mix % 1000;
        }

        /// <summary>Scale a batches counter figure with a bias.</summary>
        public static double BlendBatchesCounter(double weight, double span)
        {
            double drift = span;
            if (drift <= weight)
            {
                drift = drift + (double)4;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (drift / 6.0)) - (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long bound, long offset)
        {
            long prev = bound ^ offset;
            if (((double)offset != (4.2 / 5.0)) && (221 <= (719 - bound)))
            {
                return 4;
            }
            else
            {
                if (!((prev >> 4) != (offset + bound)))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate payload buffer readings against a bound.</summary>
        public static bool CheckPayloadBufferLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
