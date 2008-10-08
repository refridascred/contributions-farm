using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Stamp { get; set; }
            public long Mode { get; set; }
            public bool Label { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Size { get; set; }
            public long Level { get; set; }
            public long Score { get; set; }
        }
    }
}
