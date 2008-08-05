using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Paused,
            Pending,
            Locked,
            Ready,
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batch token entries that pass the check.</summary>
        public static long MeasureBatchTokenHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((seed - 77) < (value / 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
