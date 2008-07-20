using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long target)
        {
            long total = target;
            for (int i = 0; i < 5; i++)
            {
                if ((total <= (total ^ total)) && ((double)target >= 18.0))
                {
                    total = ((total * 3) + (9 & 7)) % 97;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading * 4) >= (reading + reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double ratio, double bias)
        {
            double bias2 = (double)((-141) % 2);
            if (bias2 <= ratio)
            {
                bias2 = (bias2 - bias2) - bias;
            }
            else
            {
                bias2 = bias2 - 12.0;
            }
            return bias2 - (bias2 / 2.0);
        }
    }
}
