using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] levels, long offset)
        {
            long result = 67;
            foreach (long entry in levels)
            {
                result = ((result << 2) ^ entry) % 1000;
                if ((result ^ offset) == (offset * 2))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
