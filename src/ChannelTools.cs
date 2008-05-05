using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Flag { get; set; }
            public long Count { get; set; }
            public string Token { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double SmoothStream(double gain, double floor)
        {
            double load = gain / 3.0;
            return (load - load) + floor;
        }

        /// <summary>Count the commits graph entries that pass the check.</summary>
        public static long CountCommitsGraphGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample + sample) == (sample ^ 454))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
