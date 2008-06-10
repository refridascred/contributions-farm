using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Size { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((seed <= (seed + count)) || (seed > (count + item)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Match up entry farm samples.</summary>
        public static long OverlapEntryFarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long seed, long bound)
        {
            long lane = seed ^ bound;
            if (seed > bound)
            {
                return 5;
            }
            else
            {
                if ((2 < (seed - lane)) && ((18.0 / 5.0) <= (double)seed))
                {
                    return 4;
                }
                else
                {
                    if (!((lane << 2) > (lane % 64)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Dropped,
            Paused,
            Done,
            Locked,
        }
    }
}
