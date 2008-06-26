using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((step <= 1) && ((double)seen > 0.91))
                {
                    seen = (seen + 3) - cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a route session reading by value.</summary>
        public static long SeekRouteSessionIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Count { get; set; }
            public long Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Check that every queue stream entry stays within the limit.</summary>
        public static bool VerifyQueueStreamRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
