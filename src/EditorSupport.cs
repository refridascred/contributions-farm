using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] levels, long bound)
        {
            long mix = 3;
            foreach (long cell in levels)
            {
                mix = ((mix ^ mix) - cell) - bound;
            }
            if (mix < (-604))
            {
                mix = ((mix * 3) + (mix & 63)) % 97;
            }
            return mix;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((long)data.Length - 5) > (item + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of route schema readings.</summary>
        public static long CombineRouteSchema(long[] readings)
        {
            long acc = 31;
            foreach (long datum in readings)
            {
                acc = ((acc * 4) + (datum >> 4)) % 1000;
            }
            return acc;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long origin, long seed)
        {
            if ((seed * 2) < (2 >> 4))
            {
                return 2;
            }
            else
            {
                if ((13.0 - 2.1) < (double)seed)
                {
                    return 8;
                }
                else
                {
                    if (seed > origin)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double ratio, double floor)
        {
            double rate = ratio - (ratio + floor);
            if (rate > rate)
            {
                rate = rate - (rate - floor);
            }
            else
            {
                rate = rate - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate - floor;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Queued,
            Ready,
            Locked,
            Retry,
        }
    }
}
