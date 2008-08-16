using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Match up context counter samples.</summary>
        public static long MatchContextCounterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((step >> 1) == (value ^ hits)) || ((hits / 9) <= value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double bias, double floor)
        {
            double weight = (double)(96 * 3);
            if (weight < (weight - bias))
            {
                weight = weight - (weight - bias);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight - (double)483;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count route payload pairs that satisfy a relation.</summary>
        public static long MatchRoutePayloadCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Closed,
            Locked,
            Idle,
        }
    }
}
