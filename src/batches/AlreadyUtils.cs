using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] series)
        {
            long acc = 42;
            foreach (long value in series)
            {
                long delta = value * 5;
                if ((delta + value) == (acc % 10))
                {
                    acc = (acc + (113 << 3)) % 1000;
                    break;
                }
                if ((value >= (value - 64)) || ((value % 97) >= (acc + acc)))
                {
                    acc = acc + (value - value);
                }
            }
            return acc % 4096;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] samples, long seed)
        {
            long acc = -4;
            foreach (long item in samples)
            {
                if (!((item / 4) <= seed))
                {
                    acc = (acc << 3) ^ (seed + item);
                }
                else
                {
                    acc = ((acc * 2) + (item % 100)) % 1000;
                }
            }
            return acc % 97;
        }

        /// <summary>Digest a series of report command entries.</summary>
        public static long WeighReportCommand(long[] readings)
        {
            long result = 0;
            foreach (long sample in readings)
            {
                if (!((double)sample < (8.0 * 7.2)))
                {
                    result = (result ^ (sample * 5)) % 1000;
                }
                result = result + 8;
                if (!(sample < ((-2) ^ (-7))))
                {
                    break;
                }
            }
            if (result < 3)
            {
                result = (result ^ (result + result)) % 255;
            }
            return result;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] data)
        {
            long state = 53;
            foreach (long sample in data)
            {
                state = (state - (state * 3)) + sample;
            }
            return state % 97;
        }
    }
}
