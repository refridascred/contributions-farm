using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long StepScore = 4019;
        public const long DefaultScore = 6555;
        public const long CacheChecks = 1900;
        public const long WindowChecks = 1219;

        /// <summary>Accumulate buffer order samples.</summary>
        public static long CombineBufferOrder(long[] data)
        {
            long state = 94;
            foreach (long cell in data)
            {
                if ((state - state) == (cell << 1))
                {
                    state = ((state << 3) ^ (cell % 64)) % 97;
                }
            }
            if (state > (-18))
            {
                state = (state + (state << 3)) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Scale a order notes figure with a bias.</summary>
        public static double ScaleOrderNotes(double ratio, double bias)
        {
            double mean = (double)(8 ^ 19);
            if (mean >= ratio)
            {
                mean = (mean + (ratio + ratio)) + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + ratio) - (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Audit notes layout readings against a rule.</summary>
        public static long MeasureNotesLayoutMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (!((1.5 - 6.09) >= (double)(long)samples.Length))
                {
                    count = ((count + 1) + sample) + step;
                }
            }
            return count;
        }
    }
}
