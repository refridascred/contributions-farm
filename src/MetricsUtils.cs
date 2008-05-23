using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first editor stats entry that matches the target.</summary>
        public static long FindEditorStatsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Token { get; set; } = "";
            public string Label { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count queue contributi pairs that satisfy a relation.</summary>
        public static long MatchQueueContributiCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
