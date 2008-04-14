using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSpan = 7170;
        public const long BurstSupport = 8463;
        public const double SoftSupport = 48.15;
        public const string DefaultSupport = "latest-1";

        /// <summary>Grade a batch format value against two limits.</summary>
        public static long ClassifyBatchFormat(long origin, long offset)
        {
            if ((origin >> 4) >= origin)
            {
                return 7;
            }
            else
            {
                if (!((offset / 4) >= origin))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Stale,
            Locked,
            Pending,
            Draft,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] items)
        {
            long anchor = 644;
            foreach (long datum in items)
            {
                if (((datum * 2) <= (anchor << 1)) || (anchor <= (anchor - datum)))
                {
                    anchor = (anchor ^ (datum + anchor)) % 255;
                }
            }
            return anchor % 65521;
        }
    }
}
