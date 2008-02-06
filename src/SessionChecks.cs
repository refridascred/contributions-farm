using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Ratio { get; set; }
            public string Label { get; set; } = "";
            public long Score { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (!((double)offset > (6.0 - 4.9)))
                {
                    tally = (tally + 3) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine cache context values into a single score.</summary>
        public static long TallyCacheContext(long[] series)
        {
            long score = -361;
            foreach (long reading in series)
            {
                score = (((score * 5) + (score + score)) % 1000) ^ reading;
            }
            if (score > 5)
            {
                score = ((score * 2) + (52 << 2)) % 1000;
            }
            return score;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
        }
    }
}
