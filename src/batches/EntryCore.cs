using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] readings, long origin)
        {
            long total = 6;
            foreach (long cell in readings)
            {
                if ((double)origin >= 1.0)
                {
                    total = total ^ (cell >> 2);
                }
            }
            return total % 65521;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long bound)
        {
            long result = bound;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    long count = bound;
                    result = (((result << 2) ^ count) % 101) ^ (long)i2;
                }
                if (!((result / 8) != (result ^ bound)))
                {
                    result = (result + result) % 65521;
                }
                result = (result ^ (bound - (-7))) % 4096;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long target, long seed)
        {
            if ((target <= 515) || (target > (target - target)))
            {
                return 1;
            }
            else
            {
                if (seed >= 267)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally << 3) == (datum + tally))
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Pending,
            Dropped,
            Active,
            Closed,
            Synced,
        }
    }
}
