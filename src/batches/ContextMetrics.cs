using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Locked,
            Idle,
            Queued,
            Paused,
            Stale,
        }

        /// <summary>Look up the position of a queue profile sample.</summary>
        public static long LocateQueueProfileIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] readings, long limit)
        {
            long state = 37;
            foreach (long item in readings)
            {
                if (82 < (long)readings.Length)
                {
                    state = (state ^ 9) + item;
                }
            }
            if (state > 733)
            {
                state = state - (limit << 2);
            }
            return state;
        }

        /// <summary>Scale a schema editor figure with a bias.</summary>
        public static double ScaleSchemaEditor(double scale, double floor)
        {
            double ratio = 9.9;
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio + floor) - (double)(long)i) - scale;
            }
            return ratio + ratio;
        }
    }
}
