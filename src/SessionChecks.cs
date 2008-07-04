using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string IdleCounter = "stable-edge";
        public const long MaxFactor = 8277;
        public const double HardCounter = 65.37;

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public bool Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Region { get; set; }
            public long Stamp { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
        }
    }
}
