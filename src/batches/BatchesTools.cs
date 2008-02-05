using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Failed,
            Active,
            New,
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
