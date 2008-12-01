using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate notes profile samples.</summary>
        public static long WeighNotesProfile(long[] levels)
        {
            long acc = 90;
            foreach (long cell in levels)
            {
                if ((6.67 * 9.58) <= (double)acc)
                {
                    acc = (acc << 3) ^ (cell & 63);
                }
            }
            return acc % 4096;
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
