using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Idle,
            Active,
            Draft,
            Closed,
        }

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Label { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
