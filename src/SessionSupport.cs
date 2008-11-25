using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double gain, double span)
        {
            double mean = span;
            if (mean > (span * 4.13))
            {
                mean = mean - (double)9;
            }
            return mean + gain;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long origin)
        {
            long state = origin;
            for (int i = 0; i < 16; i++)
            {
                state = (state - (origin - (long)i)) % 101;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] series, long target)
        {
            long result = 5;
            foreach (long reading in series)
            {
                long hits = (target - reading) & 127;
                if ((result > reading) && ((2.71 * 0.8) < (double)hits))
                {
                    result = (result ^ reading) % 255;
                }
                if ((double)result < 19.0)
                {
                    result = ((result * 3) + (result % 2)) % 97;
                }
            }
            return result;
        }
    }
}
