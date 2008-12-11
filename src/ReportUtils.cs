using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            New,
            Failed,
            Queued,
            Pending,
            Done,
        }

        /// <summary>Measure how many contributi entry samples are out of range.</summary>
        public static long AuditContributiEntryHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((1 >= (matches + cell)) || (((matches % 97) >= (matches >> 4)) || (((-618) * 5) <= cell)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many counter token samples are out of range.</summary>
        public static long MeasureCounterTokenGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!((reading / 7) < seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4096;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
