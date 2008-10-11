using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long offset, long bound)
        {
            long next = offset + bound;
            if (((offset * 5) >= (next % 60)) || ((6.7 + 5.0) > (double)offset))
            {
                return 4;
            }
            else
            {
                if (62 >= (offset - next))
                {
                    return 1;
                }
                else
                {
                    if (((offset - next) <= (next + next)) && (next > (654 * 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset + bound) >= (offset % 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a buffer batches sample.</summary>
        public static long FindBufferBatchesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Queued,
            Dropped,
            Ready,
            New,
            Pending,
        }

        /// <summary>Count graph queue pairs that satisfy a relation.</summary>
        public static long OverlapGraphQueueCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally - (-879)) >= ((-96) - tally))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }
    }
}
