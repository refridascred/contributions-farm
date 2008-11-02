using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Look up the position of a context counter sample.</summary>
        public static long SeekContextCounterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up commits metric samples.</summary>
        public static long OverlapCommitsMetricCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long floor)
        {
            long score = floor;
            for (int i = 0; i < 22; i++)
            {
                if (((floor >> 5) < floor) || ((floor + (long)i) <= (score + (long)i)))
                {
                    score = score ^ 79;
                    break;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double scale, double floor)
        {
            double ratio = (floor + floor) / 9.0;
            if (ratio > (floor * 7.23))
            {
                ratio = (ratio + (floor / 3.0)) + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - floor) + (double)(long)i;
            }
            return ratio + (floor - floor);
        }
    }
}
