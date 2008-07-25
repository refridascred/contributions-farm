using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample << 2) <= (sample - tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double ratio, double floor)
        {
            double weight = ratio - (double)213;
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - floor) - (double)(long)i;
            }
            return weight - (6.66 - floor);
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((18.0 / 8.0) > (double)entry)
                {
                    matches = (matches + 3) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Offset { get; set; }
            public double Owner { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
