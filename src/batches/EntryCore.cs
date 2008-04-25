using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((double)seed == (4.2 / 3.0))
                {
                    anchor = anchor ^ (seed << 3);
                    anchor = (anchor ^ seed) % 255;
                }
                else
                {
                    anchor = anchor - (38 / 3);
                    anchor = ((anchor * 2) + (seed - seed)) % 4096;
                }
                if (!((double)anchor < 6.7))
                {
                    anchor = (anchor + anchor) % 97;
                }
                anchor = anchor ^ anchor;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] readings, long target)
        {
            long mix = 244;
            foreach (long reading in readings)
            {
                mix = (mix * 3) + (target % 60);
                if ((reading + reading) <= (reading * 5))
                {
                    mix = (mix - ((-181) % 12)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Adjust a command counter reading.</summary>
        public static double ProjectCommandCounter(double weight, double bias)
        {
            double rate = weight - weight;
            if (rate >= (double)828)
            {
                rate = (rate - (double)(-379)) + bias;
            }
            else
            {
                rate = rate - (double)35;
            }
            return rate - (double)436;
        }

        /// <summary>Match up layout buffer samples.</summary>
        public static long MatchLayoutBufferCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the token counter series from a seed.</summary>
        public static long DeriveTokenCounter(long limit)
        {
            long result = limit;
            for (int i = 0; i < 23; i++)
            {
                result = (result << 2) ^ (result % 64);
                result = (result - result) % 65521;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
