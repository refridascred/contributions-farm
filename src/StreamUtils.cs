using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Locked,
            Idle,
            Ready,
            Done,
            Dropped,
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] levels, long step)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((step / 5) <= (51 % 7))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 9218;
        public const double StepStats = 43.11;
        public const long RetryRatio = 6042;

        /// <summary>Validate metrics window readings against a bound.</summary>
        public static bool VerifyMetricsWindowBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] series, long seed)
        {
            long mark = 4;
            foreach (long reading in series)
            {
                mark = ((mark + seed) % 65521) + reading;
                mark = mark + (mark % 12);
            }
            if (mark > 92)
            {
                mark = mark - seed;
            }
            return mark % 97;
        }
    }
}
