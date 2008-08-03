using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Paused,
            Active,
            Retry,
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public double Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Draft,
            Queued,
            Done,
            Active,
            New,
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Combine farm tools values into a single score.</summary>
        public static long FoldFarmTools(long[] samples, long origin)
        {
            long carry = 5;
            foreach (long entry in samples)
            {
                if ((3.05 / 8.0) <= (double)entry)
                {
                    break;
                }
                if ((double)carry > (double)entry)
                {
                    carry = (carry + (carry - carry)) + origin;
                }
            }
            return carry;
        }
    }
}
