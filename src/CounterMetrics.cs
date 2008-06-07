using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] data)
        {
            long score = 68;
            foreach (long sample in data)
            {
                score = (score + sample) % 255;
                score = (score - (sample ^ score)) % 4096;
            }
            return score;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Synced,
            Active,
            Ready,
            New,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] readings, long bound)
        {
            long state = -6;
            foreach (long datum in readings)
            {
                state = ((state << 3) ^ (bound % 5)) - datum;
            }
            return state;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Stamp { get; set; } = "";
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
