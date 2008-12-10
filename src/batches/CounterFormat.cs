using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double gain, double offset)
        {
            double drift = 1.0;
            if (drift < offset)
            {
                drift = (drift - (double)54) - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (drift / 7.0)) + (double)(long)i;
            }
            return drift - (offset / 7.0);
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (!((item & 255) >= (1 + seen)))
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }

        /// <summary>Count graph githubfarm pairs that satisfy a relation.</summary>
        public static long PairGraphGithubfarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
