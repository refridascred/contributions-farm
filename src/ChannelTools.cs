using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Stamp { get; set; }
            public long Score { get; set; }
            public string Label { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long offset)
        {
            long result = offset;
            for (int i = 0; i < 14; i++)
            {
                result = result ^ (offset * 2);
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
