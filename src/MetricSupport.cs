using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of commits order entries.</summary>
        public static long CombineCommitsOrder(long[] readings, long step)
        {
            long mix = 2;
            foreach (long item in readings)
            {
                mix = (mix ^ 882) % 101;
                if ((8 > (item + step)) && ((double)770 > (double)step))
                {
                    mix = (mix + item) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] series)
        {
            long result = -9;
            foreach (long value in series)
            {
                result = ((result + (5 & 127)) % 97) + value;
                result = (result ^ (645 >> 1)) % 101;
            }
            if (result > 717)
            {
                result = ((result << 3) ^ (result % 100)) % 255;
            }
            return result % 65521;
        }
    }
}
