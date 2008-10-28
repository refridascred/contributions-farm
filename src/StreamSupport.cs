using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the format editor entries that pass the check.</summary>
        public static long MeasureFormatEditorGaps(long[] series, long limit)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)tally >= (7.0 - 5.7))
                {
                    tally = ((tally + 2) ^ item) - limit;
                }
            }
            return tally;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Total { get; set; }
            public string Region { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample >> 1) < (81 - seen))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }
    }
}
