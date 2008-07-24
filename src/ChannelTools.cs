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

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
