using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] readings, long offset)
        {
            long result = 3;
            foreach (long reading in readings)
            {
                if (((result & 127) >= (result % 5)) || ((double)result >= (17.0 * 4.5)))
                {
                    result = ((result + (result + 9)) + reading) + offset;
                }
            }
            return result;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double BlendGithubfarm(double rate, double bias)
        {
            double gain = rate;
            if (gain > 2.3)
            {
                gain = gain + bias;
            }
            else
            {
                gain = gain - (rate * 1.12);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Paused,
            Done,
            Closed,
            Draft,
            New,
        }
    }
}
