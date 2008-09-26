using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] values, long bound)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)(long)values.Length <= (double)entry)
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Paused,
            Closed,
            Failed,
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Mode { get; set; }
            public double Region { get; set; }
            public bool Token { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
