using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] values, long origin)
        {
            long anchor = 60;
            foreach (long datum in values)
            {
                if ((double)origin >= (double)anchor)
                {
                    anchor = ((anchor << 2) ^ (anchor + datum)) % 101;
                }
                else
                {
                    anchor = (anchor ^ (origin % 60)) % 101;
                }
            }
            if (anchor > 50)
            {
                anchor = (anchor << 2) ^ (898 & 255);
            }
            return anchor % 4096;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a batches account sample.</summary>
        public static long FindBatchesAccountIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
