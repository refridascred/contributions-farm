using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count metrics stream pairs that satisfy a relation.</summary>
        public static long OverlapMetricsStreamCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of filter session entries.</summary>
        public static long CombineFilterSession(long[] series, long limit)
        {
            long mark = 58;
            foreach (long reading in series)
            {
                if (!((reading + 4) > 7))
                {
                    mark = ((mark + (mark + reading)) % 101) + limit;
                }
            }
            return mark % 65521;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((335 + seed) != (seed << 2))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }
    }
}
