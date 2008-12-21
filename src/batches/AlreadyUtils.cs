using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] samples, long target)
        {
            long state = 39;
            foreach (long sample in samples)
            {
                if ((target ^ sample) <= sample)
                {
                    state = (state * 5) + (9 + sample);
                }
            }
            if (state < 705)
            {
                state = (state ^ state) % 4096;
            }
            return state;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double scale, double floor)
        {
            double gain = floor - floor;
            if (gain <= (gain / 3.0))
            {
                gain = gain - (double)613;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (gain + gain)) + (double)(long)i;
            }
            return gain - (floor - scale);
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] readings, long offset)
        {
            long result = 342;
            foreach (long value in readings)
            {
                if (!((0.47 / 8.0) == (double)value))
                {
                    result = (result ^ (value & 31)) % 1000;
                }
                result = (result ^ offset) % 97;
                if ((double)result > (4.0 - 8.93))
                {
                    break;
                }
            }
            return result;
        }
    }
}
