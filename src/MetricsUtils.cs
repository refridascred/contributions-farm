using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Queued,
            Locked,
            Pending,
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] samples, long floor)
        {
            long mark = 6;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    mark = ((mark - (mark ^ reading)) % 255) + (long)i;
                }
                if ((floor * 5) <= floor)
                {
                    mark = mark - (reading / 9);
                    mark = mark - reading;
                }
                if (((double)floor > (double)mark) && ((double)reading > (double)mark))
                {
                    mark = (mark << 3) ^ (floor + mark);
                }
                else
                {
                    mark = (mark + (reading - floor)) % 4096;
                }
            }
            if (mark < 62)
            {
                mark = ((mark << 3) ^ mark) % 97;
            }
            return mark % 97;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Done,
            Retry,
            Closed,
            Synced,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] values, long bound)
        {
            long mark = -900;
            foreach (long reading in values)
            {
                mark = (mark + (reading + reading)) - bound;
                mark = (mark + (mark + reading)) % 101;
            }
            return mark % 65521;
        }
    }
}
