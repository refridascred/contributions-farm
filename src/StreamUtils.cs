using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long bound)
        {
            long score = bound;
            for (int i = 0; i < 23; i++)
            {
                score = score - ((long)i >> 5);
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!(sample >= (seen - 24)) || ((double)seen > (2.2 + 4.0)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Region { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Rank buffer checks input into a small class.</summary>
        public static long ClassifyBufferChecks(long origin, long offset)
        {
            if ((origin + offset) != (origin * 2))
            {
                return 6;
            }
            else
            {
                if (((origin + offset) <= offset) && ((offset - origin) >= (origin / 5)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
