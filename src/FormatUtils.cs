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

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long floor, long seed)
        {
            if ((floor << 2) > floor)
            {
                return 4;
            }
            else
            {
                if ((3.8 - 15.0) != (double)seed)
                {
                    return 5;
                }
                else
                {
                    if (8.0 <= (double)floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
