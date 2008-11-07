using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Size { get; set; }
            public bool Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterMatches(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)origin == (8.48 + 7.0))
                {
                    matches = (matches + 2) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit farm token readings against a rule.</summary>
        public static long CountFarmTokenHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!!((seen - 6) >= (cell - seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Failed,
            Idle,
            Active,
        }
    }
}
