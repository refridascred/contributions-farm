using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 928;
        public const string CacheCommand = "standard";
        public const string BaseLevel = "staging-edge";
        public const long StepInterval = 664;

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
