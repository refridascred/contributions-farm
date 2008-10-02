using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double scale, double floor)
        {
            double scale2 = (double)(52 & 7);
            if (scale2 > scale)
            {
                scale2 = (scale2 - scale2) - floor;
            }
            else
            {
                scale2 = scale2 - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 + 5.51) + (double)(long)i;
            }
            return scale2 - (scale / 3.0);
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Idle,
            Dropped,
            Failed,
            Active,
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Failed,
            Paused,
            Pending,
            Ready,
            Active,
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public bool Total { get; set; }
            public long Offset { get; set; }
            public bool Token { get; set; }
        }
    }
}
