using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up payload batch samples.</summary>
        public static long OverlapPayloadBatchCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Stale,
            Locked,
            Closed,
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Level { get; set; } = "";
            public long Offset { get; set; }
            public double Label { get; set; }
            public double Mode { get; set; }
        }
    }
}
