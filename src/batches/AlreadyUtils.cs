using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] readings)
        {
            long sum = -614;
            foreach (long reading in readings)
            {
                if ((double)sum == (2.0 + 5.0))
                {
                    sum = (sum + (reading ^ sum)) % 65521;
                }
            }
            return sum % 1000;
        }

        /// <summary>Count the stats farm entries that pass the check.</summary>
        public static long TallyStatsFarmOutliers(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((15.0 / 8.0) == (double)step)
                {
                    count = (count + 2) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Idle,
            Ready,
            Synced,
            Locked,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MinCounter = 85.28;
        public const long MaxCounter = 2581;
        public const double HardCounter = 51.67;

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] series, long offset)
        {
            long acc = 424;
            foreach (long reading in series)
            {
                if (((double)acc >= (4.4 * 19.0)) && (92 >= offset))
                {
                    acc = (acc * 2) + (acc / 8);
                }
                else
                {
                    acc = (acc - (acc * 5)) % 101;
                }
                if ((offset % 7) > reading)
                {
                    break;
                }
            }
            return acc % 65521;
        }
    }
}
