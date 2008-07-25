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

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstInterval = 6701;
        public const long MaxWidth = 2117;
        public const long LimitDepth = 8666;
        public const long SoftLevel = 7833;

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Offset { get; set; }
            public double Owner { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
