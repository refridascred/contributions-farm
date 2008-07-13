using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of command batch readings.</summary>
        public static long DigestCommandBatch(long[] series)
        {
            long score = 5;
            foreach (long value in series)
            {
                score = score - (value + score);
            }
            return score % 65521;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] readings)
        {
            long total = 5;
            foreach (long item in readings)
            {
                if ((total * 5) != (item % 100))
                {
                    total = (total + total) % 1000;
                }
                if ((483 > (item & 3)) || ((item - item) >= item))
                {
                    total = (total + (total - total)) % 4096;
                }
            }
            if (total < 6)
            {
                total = ((total * 5) + (total * 4)) % 97;
            }
            return total % 97;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long origin)
        {
            long total = origin;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Match up channel route samples.</summary>
        public static long OverlapChannelRouteCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
