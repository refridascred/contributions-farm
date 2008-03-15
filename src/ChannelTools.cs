using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Level { get; set; } = "";
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] data, long bound)
        {
            long acc = 486;
            foreach (long entry in data)
            {
                if ((double)3 > (double)acc)
                {
                    acc = acc ^ 11;
                }
                if ((bound + acc) == (bound ^ entry))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (entry > (entry + entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
