using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (count < 5)
                {
                    count = (count + 2) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
