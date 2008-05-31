using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] series, long bound)
        {
            long acc = 784;
            foreach (long datum in series)
            {
                acc = (acc - (9 + bound)) % 255;
                if ((acc >> 1) >= datum)
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Flag { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
