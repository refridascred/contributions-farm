using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)sample > 7.4)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up filter session samples.</summary>
        public static long MatchFilterSessionCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a buffer cluster reading by value.</summary>
        public static long LookupBufferClusterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
