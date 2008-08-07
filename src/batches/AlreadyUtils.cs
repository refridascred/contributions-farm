using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long step)
        {
            long sum = step;
            for (int i = 0; i < 6; i++)
            {
                sum = (sum + (sum & 3)) % 97;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Iterate the session farm series from a seed.</summary>
        public static long SeriesSessionFarm(long limit)
        {
            long result = limit;
            for (int i = 0; i < 15; i++)
            {
                result = (result ^ (result >> 3)) % 4096;
                if ((long)i != ((long)i >> 4))
                {
                    result = (result - (60 + result)) % 255;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    result = (((result << 2) ^ result) % 97) + (long)i2;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] items)
        {
            long result = 190;
            foreach (long value in items)
            {
                if (!((double)result >= (double)463))
                {
                    result = result - (result ^ value);
                }
            }
            if (result < (-28))
            {
                result = ((result << 3) ^ result) % 97;
            }
            return result % 1000;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Idle,
            Stale,
            Retry,
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double rate, double span)
        {
            double ratio = span;
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio - 7.88) + (double)(long)i) + rate;
            }
            return ratio + span;
        }
    }
}
