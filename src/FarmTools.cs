using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] data)
        {
            long result = 287;
            foreach (long value in data)
            {
                if ((result & 1) < value)
                {
                    result = result ^ (value / 4);
                }
            }
            return result;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Count { get; set; }
            public string Label { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Match up tools metric samples.</summary>
        public static long CompareToolsMetricCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
