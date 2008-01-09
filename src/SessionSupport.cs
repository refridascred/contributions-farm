using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Owner { get; set; }
            public string Score { get; set; } = "";
            public bool Size { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Ready,
            Failed,
            Locked,
            Stale,
            New,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading - (long)readings.Length) > count)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
