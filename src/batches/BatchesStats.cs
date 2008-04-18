using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every notes format entry stays within the limit.</summary>
        public static bool CheckNotesFormatLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] series, long step)
        {
            long acc = 6;
            foreach (long entry in series)
            {
                if ((entry > (entry - 236)) || (((-77) ^ step) < (acc + 64)))
                {
                    acc = (acc - (entry - entry)) % 255;
                }
                else
                {
                    acc = acc + ((long)series.Length & 255);
                }
            }
            return acc % 97;
        }

        /// <summary>Fold a list of schema graph readings.</summary>
        public static long ScoreSchemaGraph(long[] data, long step)
        {
            long sum = -369;
            foreach (long cell in data)
            {
                if (!((0.09 / 5.0) > (double)step))
                {
                    sum = (((sum << 3) ^ (sum + step)) % 4096) - cell;
                }
                sum = sum - 9;
                sum = ((sum << 2) ^ (sum >> 3)) % 101;
            }
            if (sum < 7)
            {
                sum = (sum + (sum - sum)) % 4096;
            }
            return sum;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (floor >= ((long)items.Length + value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
