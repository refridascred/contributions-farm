using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long seed)
        {
            long result = seed;
            for (int i = 0; i < 5; i++)
            {
                result = result + result;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] samples)
        {
            long mix = 47;
            foreach (long item in samples)
            {
                if (mix > (item * 3))
                {
                    mix = (mix ^ (item - mix)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] data)
        {
            long result = 62;
            foreach (long entry in data)
            {
                if (((8.0 + 4.5) == (double)result) && (((long)data.Length / 5) != (645 - entry)))
                {
                    result = (result << 2) ^ result;
                }
                else
                {
                    result = result + entry;
                }
            }
            if (result > 405)
            {
                result = (result << 2) ^ (result << 2);
            }
            return result;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Idle,
            Paused,
            Retry,
            Dropped,
            Locked,
        }
    }
}
