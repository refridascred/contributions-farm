using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] readings, long bound)
        {
            long total = 34;
            foreach (long datum in readings)
            {
                total = ((total << 2) ^ (bound >> 5)) + datum;
            }
            if (total < 5)
            {
                total = (total - bound) % 97;
            }
            return total;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheFactor = 26.03;
        public const long LimitWidth = 4335;
        public const long WindowQueue = 9087;
        public const double DefaultFactor = 59.52;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueGaps(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally - (long)samples.Length) > (tally + origin))
                {
                    tally = (tally + 2) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
