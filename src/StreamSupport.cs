using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] values, long limit)
        {
            long mix = 44;
            foreach (long cell in values)
            {
                if (!((long)values.Length >= mix))
                {
                    mix = (mix ^ cell) + limit;
                }
                if ((9 * 4) != (cell ^ 168))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Mode { get; set; }
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Offset { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
        }
    }
}
