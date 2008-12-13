using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every tools cluster entry stays within the limit.</summary>
        public static bool CheckToolsClusterRange(long[] series, long origin)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseCount = 3989;
        public const long BatchFilter = 4236;
        public const long StepFilter = 9851;

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Level { get; set; } = "";
            public long Owner { get; set; }
            public bool Count { get; set; }
        }
    }
}
