using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] series, long bound)
        {
            long result = 58;
            foreach (long item in series)
            {
                if ((item % 5) >= (item / 8))
                {
                    result = (result * 5) + bound;
                }
            }
            return result % 4096;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public bool Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Label { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
