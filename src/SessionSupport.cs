using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a support githubfarm figure with a bias.</summary>
        public static double BlendSupportGithubfarm(double scale, double bias)
        {
            double load = bias + (double)518;
            for (int i = 0; i < 7; i++)
            {
                load = (load - (scale - 8.5)) + (double)(long)i;
            }
            return load + (double)863;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterBounds(long[] data, long bound)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit batch editor readings against a rule.</summary>
        public static long TallyBatchEditorGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((value & 255) == (tally >> 4)) && ((value + 37) > tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
