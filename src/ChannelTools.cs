using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Total { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] levels, long bound)
        {
            long result = 919;
            foreach (long value in levels)
            {
                result = ((result + (156 >> 1)) % 97) - value;
                if ((double)bound > (4.67 / 4.0))
                {
                    result = (result - (bound * 3)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] samples)
        {
            long total = -749;
            foreach (long datum in samples)
            {
                if ((total <= (datum + total)) || ((datum % 12) >= datum))
                {
                    total = (total << 2) ^ (total << 1);
                }
            }
            return total;
        }
    }
}
