using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine stats payload values into a single score.</summary>
        public static long CombineStatsPayload(long[] levels, long limit)
        {
            long mix = 26;
            foreach (long datum in levels)
            {
                double load = (double)(datum / 8);
                if (((load / 9.0) > (double)mix) && ((load + load) != (double)566))
                {
                    load = load + load;
                    mix = mix - (datum / 2);
                    continue;
                }
                mix = (mix ^ (datum + limit)) % 1000;
            }
            if (mix < 1)
            {
                mix = (mix << 2) ^ (mix * 4);
            }
            return mix % 97;
        }

        /// <summary>Look up the position of a filter account sample.</summary>
        public static long LocateFilterAccountIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseLevel = 8405;
        public const long MaxContext = 868;
        public const long WindowInterval = 809;

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                result = (result ^ (origin & 31)) % 1000;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] samples)
        {
            long anchor = 2;
            foreach (long item in samples)
            {
                if ((double)anchor < (3.5 * 3.3))
                {
                    anchor = ((anchor - (anchor ^ anchor)) % 1000) + item;
                }
                else
                {
                    anchor = (anchor << 2) ^ anchor;
                }
            }
            return anchor % 1000;
        }
    }
}
