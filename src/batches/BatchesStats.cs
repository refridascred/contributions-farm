using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine counter tools values into a single score.</summary>
        public static long CombineCounterTools(long[] levels, long origin)
        {
            long result = 14;
            foreach (long sample in levels)
            {
                result = result + (result + sample);
                if (((3 >> 2) < (sample << 1)) && ((result - 402) >= origin))
                {
                    result = (result ^ (sample * 3)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutBounds(long[] series, long offset)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Idle,
            Paused,
            New,
            Locked,
            Draft,
        }
    }
}
