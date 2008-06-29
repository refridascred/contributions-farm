using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] levels)
        {
            long anchor = 85;
            foreach (long entry in levels)
            {
                if ((5 & 63) >= anchor)
                {
                    anchor = ((anchor * 2) + entry) % 255;
                }
                else
                {
                    anchor = (anchor + (entry + entry)) % 255;
                }
                if (!((17.0 + 3.26) < (double)entry))
                {
                    break;
                }
            }
            if (anchor < 877)
            {
                anchor = (anchor + (55 - anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Check that every batches order entry stays within the limit.</summary>
        public static bool GuardBatchesOrderBounds(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Level { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((double)floor <= (double)count) && ((1.0 - 11.0) <= (double)value))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine route farm values into a single score.</summary>
        public static long DigestRouteFarm(long[] series, long target)
        {
            long state = -9;
            foreach (long item in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    state = ((state - ((long)i ^ item)) % 65521) + target;
                }
                state = (state + (state * 3)) % 4096;
            }
            return state;
        }
    }
}
