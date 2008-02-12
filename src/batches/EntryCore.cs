using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((-95) >= (tally - reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Ready,
            Queued,
            Failed,
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Flag { get; set; } = "";
            public bool Total { get; set; }
            public double Count { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Match up account order samples.</summary>
        public static long CompareAccountOrderCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (!((double)cell == (3.0 / 9.0)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
