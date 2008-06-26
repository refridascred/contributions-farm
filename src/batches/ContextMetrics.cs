using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (((count - count) < count) || (((count / 4) == (count % 3)) && ((item - count) >= (target & 255))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit record channel readings against a rule.</summary>
        public static long TallyRecordChannelOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (value <= tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
