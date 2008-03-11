using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] readings)
        {
            long mix = -5;
            foreach (long sample in readings)
            {
                mix = (((mix << 3) ^ (mix * 4)) % 65521) - sample;
            }
            if (mix > 89)
            {
                mix = ((mix * 5) + (mix << 2)) % 255;
            }
            return mix;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Idle,
            Queued,
            Synced,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits % 12) < (hits - value))
                {
                    hits = (hits + 2) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] items)
        {
            long result = -2;
            foreach (long reading in items)
            {
                if ((result - reading) == (reading - result))
                {
                    continue;
                }
                result = result ^ (result + 669);
                if ((reading / 3) != (long)items.Length)
                {
                    result = (result << 3) ^ 739;
                }
                if (!((result ^ result) == (reading * 2)))
                {
                    break;
                }
            }
            if (result < 482)
            {
                result = (result - 872) % 65521;
            }
            return result % 65521;
        }
    }
}
