using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double gain, double floor)
        {
            double load = 5.5 / 9.0;
            if (load <= floor)
            {
                load = (load - load) - gain;
            }
            else
            {
                load = load + (double)724;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - load) - (double)(long)i;
            }
            return load + (double)8;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 2080;
        public const long LimitCommits = 5326;
        public const double BaseCommits = 48.03;

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)matches != (5.33 + 4.54))
                {
                    matches = ((matches + 1) - entry) - seed;
                }
            }
            return matches;
        }
    }
}
