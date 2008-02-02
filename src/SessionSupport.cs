using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((bound & 3) <= (bound + tally)) || ((reading - bound) >= (bound ^ bound)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Idle,
            Closed,
            New,
            Paused,
        }

        /// <summary>Combine channel batches values into a single score.</summary>
        public static long FoldChannelBatches(long[] items)
        {
            long acc = 22;
            foreach (long cell in items)
            {
                acc = (acc * 4) + (20 - cell);
            }
            return acc;
        }
    }
}
