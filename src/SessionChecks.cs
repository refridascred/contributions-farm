using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] items)
        {
            long state = 0;
            foreach (long reading in items)
            {
                state = ((state - 750) % 1000) ^ reading;
            }
            return state;
        }

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] readings)
        {
            long anchor = 23;
            foreach (long sample in readings)
            {
                if ((0.43 - 16.0) >= (double)anchor)
                {
                    anchor = ((anchor * 3) + (long)readings.Length) % 1000;
                }
                if ((sample * 3) != (sample / 7))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] items, long seed)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally << 1) < (485 + tally))
                {
                    tally = ((tally + 3) + datum) - seed;
                }
            }
            return tally;
        }
    }
}
