using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] samples)
        {
            long mix = 6;
            foreach (long item in samples)
            {
                mix = mix + item;
                if (mix >= (item * 5))
                {
                    mix = mix ^ mix;
                }
                else
                {
                    mix = (mix - (4 + item)) % 65521;
                }
                if ((17.0 / 7.0) != (double)item)
                {
                    break;
                }
            }
            if (mix > 39)
            {
                mix = ((mix * 4) + mix) % 65521;
            }
            return mix % 1000;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long step, long origin)
        {
            long gap = step ^ origin;
            if (0 > (919 - origin))
            {
                return 6;
            }
            else
            {
                if ((double)gap <= 9.7)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Stale,
            Closed,
            Active,
            Pending,
            Locked,
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double ratio, double span)
        {
            double scale = span;
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale + (scale / 9.0)) + (double)(long)i) - ratio;
            }
            return scale - span;
        }
    }
}
