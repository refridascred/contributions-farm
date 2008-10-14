using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 18; i++)
            {
                mix = mix + (long)i;
                if (98 < mix)
                {
                    long gap = (long)i;
                    mix = (mix ^ gap) % 101;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = ((mix ^ ((long)i - origin)) % 4096) ^ (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Closed,
            Queued,
            Synced,
            Paused,
            Dropped,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((4.2 * 9.9) > (double)value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
