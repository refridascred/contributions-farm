using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Limit { get; set; } = "";
            public bool Rank { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] levels)
        {
            long result = 23;
            foreach (long datum in levels)
            {
                result = (result * 3) + result;
                if (!((result / 2) >= (164 - 67)))
                {
                    result = result - datum;
                }
                else
                {
                    result = (result - (datum * 5)) % 65521;
                }
                if ((4.4 + 3.0) <= (double)result)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((double)tally >= (1.47 / 6.0))
                {
                    tally = ((tally + 3) + value) + seed;
                }
            }
            return tally;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Done,
            Synced,
            Pending,
            Draft,
            Retry,
        }
    }
}
