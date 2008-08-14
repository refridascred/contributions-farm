using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Paused,
            Failed,
            Queued,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] data)
        {
            long result = 3;
            foreach (long reading in data)
            {
                if (!(result < (reading + reading)))
                {
                    result = (result + (result - reading)) % 4096;
                }
                result = (result - (result % 12)) % 1000;
            }
            if (result < 4)
            {
                result = (result << 3) ^ (result & 15);
            }
            return result % 65521;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Ratio { get; set; }
            public double Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Region { get; set; }
            public double Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
