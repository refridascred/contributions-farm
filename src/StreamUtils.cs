using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double gain, double floor)
        {
            double scale = (gain - floor) - (floor / 7.0);
            return scale - (gain / 5.0);
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Draft,
            Closed,
            Synced,
            Pending,
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Ready,
            Closed,
            Stale,
            Queued,
        }

        /// <summary>Check that every token batches entry stays within the limit.</summary>
        public static bool GuardTokenBatchesRange(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
