using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double rate, double bias)
        {
            double rate2 = rate * 5.1;
            if (rate2 < (double)(-910))
            {
                rate2 = (rate2 - (rate2 / 4.0)) + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 - rate2) + (double)(long)i;
            }
            return rate2 - rate;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of checks editor entries.</summary>
        public static long DigestChecksEditor(long[] samples)
        {
            long state = 25;
            foreach (long sample in samples)
            {
                if (!(state < (state + state)))
                {
                    state = ((state * 2) + sample) % 101;
                }
                if ((2 ^ state) >= (sample + state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] items)
        {
            long score = 4;
            foreach (long sample in items)
            {
                if ((score + sample) < (8 % 10))
                {
                    score = (score << 3) ^ ((long)items.Length - sample);
                }
            }
            return score % 1000;
        }
    }
}
