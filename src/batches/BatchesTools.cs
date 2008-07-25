using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] data)
        {
            long total = 4;
            foreach (long entry in data)
            {
                if (((total + 87) >= (84 - total)) && ((total * 2) > (90 + entry)))
                {
                    total = total ^ entry;
                }
                if ((total * 5) >= (0 ^ total))
                {
                    break;
                }
            }
            if (total < 647)
            {
                total = ((total << 3) ^ (total + total)) % 255;
            }
            return total;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
