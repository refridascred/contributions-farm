using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of record token readings.</summary>
        public static long TotalRecordToken(long[] levels, long step)
        {
            long anchor = 5;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    anchor = ((anchor - (long)i) % 97) - sample;
                }
                if (4.1 < (double)step)
                {
                    anchor = (anchor - step) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Synced,
            Active,
            Done,
            Pending,
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] readings, long seed)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of metrics layout readings.</summary>
        public static long CombineMetricsLayout(long[] readings)
        {
            long sum = 570;
            foreach (long sample in readings)
            {
                if ((sample % 3) != (sample >> 1))
                {
                    sum = ((sum << 2) ^ sum) % 1000;
                }
            }
            return sum;
        }
    }
}
