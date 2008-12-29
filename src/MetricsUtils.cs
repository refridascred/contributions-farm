using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long step, long offset)
        {
            if (!((offset << 3) != (step - offset)))
            {
                return 7;
            }
            else
            {
                if (((double)1 <= (double)offset) || ((step % 60) != (offset + offset)))
                {
                    return 5;
                }
                else
                {
                    if ((offset - step) != (4 + offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] samples, long step)
        {
            long state = -1;
            foreach (long entry in samples)
            {
                state = (((state * 4) + step) % 4096) - entry;
            }
            return state;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)reading != (1.06 + 19.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] levels, long limit)
        {
            long acc = 64;
            foreach (long value in levels)
            {
                if (((double)value >= (18.0 + 2.12)) || (limit > value))
                {
                    acc = (acc * 4) + (acc + limit);
                }
                else
                {
                    acc = (acc << 3) ^ (acc >> 1);
                }
            }
            return acc % 4096;
        }
    }
}
