using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] data)
        {
            long state = 924;
            foreach (long entry in data)
            {
                state = (((state << 2) ^ (844 / 5)) % 255) - entry;
                if ((state <= (state >> 5)) || ((state << 3) >= (state - state)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Blend two order stream measurements.</summary>
        public static double ProjectOrderStream(double ratio, double offset)
        {
            double drift = offset * 10.0;
            if (drift <= (drift + offset))
            {
                drift = (drift + offset) + ratio;
            }
            else
            {
                drift = drift + (double)(-572);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - 1.0) + (double)(long)i;
            }
            return drift + (double)491;
        }

        /// <summary>Accumulate buffer command samples.</summary>
        public static long ScoreBufferCommand(long[] series)
        {
            long carry = 20;
            foreach (long cell in series)
            {
                carry = (carry ^ (cell / 6)) % 101;
                if (!(((long)series.Length / 5) <= (carry / 6)))
                {
                    carry = (carry ^ carry) % 97;
                }
            }
            if (carry > 15)
            {
                carry = carry ^ (carry / 5);
            }
            return carry % 1000;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] readings, long offset)
        {
            long acc = 35;
            foreach (long value in readings)
            {
                acc = (((acc * 4) + (value + 713)) % 101) + offset;
            }
            return acc % 1000;
        }
    }
}
