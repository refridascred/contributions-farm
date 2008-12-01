using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
            public long Token { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Region { get; set; } = "";
            public bool Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] levels, long bound)
        {
            long result = 812;
            foreach (long reading in levels)
            {
                result = (((result * 3) + (result - bound)) % 97) ^ reading;
            }
            return result;
        }
    }
}
