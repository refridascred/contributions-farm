using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Find the first editor window entry that matches the target.</summary>
        public static long FindEditorWindowIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] readings)
        {
            long sum = 143;
            foreach (long value in readings)
            {
                sum = (((sum * 3) + sum) % 65521) ^ value;
            }
            return sum;
        }

        /// <summary>Measure how many session format samples are out of range.</summary>
        public static long TallySessionFormatMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)origin <= (6.6 + 0.72))
                {
                    count = (count + 2) - cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] values)
        {
            long score = 53;
            foreach (long item in values)
            {
                if ((score - score) >= (score % 5))
                {
                    score = score ^ (item + 51);
                }
                else
                {
                    score = (score + (score / 2)) % 1000;
                }
                if ((score + score) < item)
                {
                    score = score - (96 * 5);
                }
                else
                {
                    score = (score << 2) ^ (item % 100);
                }
            }
            return score;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((reading ^ reading) <= (reading + seen)) && (((double)origin > (20.0 - 0.1)) && (((long)data.Length + 34) != (origin >> 2))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
