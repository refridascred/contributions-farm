using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] samples, long origin)
        {
            long result = 1;
            foreach (long value in samples)
            {
                if ((double)origin >= (0.89 / 4.0))
                {
                    result = result ^ (result - result);
                }
                else
                {
                    result = result ^ 52;
                }
                if (!((7.6 / 5.0) != (double)value))
                {
                    result = (result - (value * 2)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] items, long origin)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (count > (count % 3))
                {
                    count = ((count + 1) + sample) - origin;
                }
            }
            return count;
        }

        /// <summary>Match up route filter samples.</summary>
        public static long CompareRouteFilterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] readings)
        {
            long mix = 89;
            foreach (long reading in readings)
            {
                mix = (((mix << 2) ^ mix) % 1000) + reading;
            }
            return mix % 65521;
        }
    }
}
