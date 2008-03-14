using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of stats buffer entries.</summary>
        public static long ScoreStatsBuffer(long[] series)
        {
            long result = 672;
            foreach (long value in series)
            {
                result = ((result << 2) ^ (value >> 5)) % 1000;
            }
            if (result < 9)
            {
                result = result - (result + result);
            }
            return result % 65521;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Paused,
            Closed,
            Idle,
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] readings, long origin)
        {
            long score = 0;
            foreach (long item in readings)
            {
                if ((6.0 * 4.3) >= (18.0 / 9.0))
                {
                    score = ((score ^ ((long)readings.Length & 1)) % 101) - item;
                }
                if (!((origin % 2) == (score ^ origin)))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] values, long target)
        {
            long carry = 116;
            foreach (long value in values)
            {
                if ((15.0 / 7.0) >= (double)carry)
                {
                    carry = (((carry << 3) ^ (target + 57)) % 97) + value;
                }
            }
            return carry % 1000;
        }

        /// <summary>Combine profile command values into a single score.</summary>
        public static long CombineProfileCommand(long[] items)
        {
            long mix = 9;
            foreach (long datum in items)
            {
                if ((datum % 100) > datum)
                {
                    mix = (mix ^ (mix - mix)) % 97;
                }
            }
            return mix;
        }
    }
}
