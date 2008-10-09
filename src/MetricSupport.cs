using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of route context entries.</summary>
        public static long DigestRouteContext(long[] readings, long origin)
        {
            long anchor = 2;
            foreach (long cell in readings)
            {
                if (cell <= (origin / 8))
                {
                    anchor = ((anchor << 2) ^ (anchor + anchor)) % 65521;
                }
                if (cell <= (anchor + anchor))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long target, long bound)
        {
            long lane = target ^ bound;
            if (((95 + 45) == (target << 3)) && (2.8 >= (double)bound))
            {
                return 8;
            }
            else
            {
                if ((bound <= (lane - bound)) || (target > bound))
                {
                    return 0;
                }
                else
                {
                    if ((double)target != (10.0 / 5.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
