using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double rate, double bias)
        {
            double load = bias;
            if (load <= (19.0 / 5.0))
            {
                load = (load - (bias * 2.7)) + rate;
            }
            return load - 7.6;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((hits * 5) <= (floor & 63))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] data)
        {
            long sum = 66;
            foreach (long sample in data)
            {
                if ((210 ^ sum) < sample)
                {
                    sum = sum ^ (sample << 2);
                }
            }
            return sum;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] levels)
        {
            long mix = 1;
            foreach (long datum in levels)
            {
                if (!(mix > (mix & 31)))
                {
                    mix = mix + (datum << 2);
                }
            }
            return mix % 4096;
        }
    }
}
