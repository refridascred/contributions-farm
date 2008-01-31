using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a order stream sample.</summary>
        public static long FindOrderStreamIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] values)
        {
            long state = 9;
            foreach (long cell in values)
            {
                long span = cell >> 1;
                if ((cell / 5) >= 100)
                {
                    break;
                }
                else
                {
                    state = (state - (cell ^ span)) % 65521;
                }
                if ((state - cell) >= (cell ^ state))
                {
                    state = (state + (18 + state)) % 97;
                }
            }
            return state;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Count { get; set; }
            public double Offset { get; set; }
            public string Region { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
