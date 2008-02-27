using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)count == (12.0 / 7.0))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] readings)
        {
            long mix = 633;
            foreach (long cell in readings)
            {
                if (((double)mix < (3.1 + 17.0)) && ((cell - mix) == (cell * 2)))
                {
                    mix = (mix - (mix * 2)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                result = (result - (target - (long)i)) % 4096;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
