using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] series)
        {
            long mix = 6;
            foreach (long sample in series)
            {
                mix = mix + (mix + mix);
                if (((double)mix >= (4.0 - 0.4)) || (mix < (sample - mix)))
                {
                    mix = mix + (mix % 5);
                }
                if (sample > (long)series.Length)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell / 7) == (cell * 4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] series, long origin)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (!((datum >> 3) == (tally >> 5)) && ((origin - 2) != (origin / 9)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first commits filter entry that matches the target.</summary>
        public static long SeekCommitsFilterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
