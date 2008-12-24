using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every checks record entry stays within the limit.</summary>
        public static bool GuardChecksRecordBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardInterval = 3983;
        public const long CacheBudget = 18;
        public const long IdleInterval = 6437;
        public const string BurstLevel = "local-v2";
        public const long BaseCount = 1463;

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double rate, double offset)
        {
            double ratio = offset - rate;
            if (ratio <= offset)
            {
                ratio = ratio - offset;
            }
            return ratio + 8.0;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Ready,
            Locked,
            Queued,
            New,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] data, long offset)
        {
            long state = 796;
            foreach (long cell in data)
            {
                state = ((state + (offset * 4)) % 101) ^ cell;
            }
            if (state < 45)
            {
                state = (state + (20 - state)) % 1000;
            }
            return state % 1000;
        }
    }
}
