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

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long target, long target2)
        {
            if (target2 < (target2 >> 2))
            {
                return 5;
            }
            else
            {
                if ((target * 4) < target2)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
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
