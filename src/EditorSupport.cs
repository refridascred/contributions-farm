using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultScore = 28.79;
        public const long StepContributi = 1300;
        public const long RetryContributi = 8326;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowDepth = 8279;
        public const long RetryBuffer = 389;
        public const long CacheScore = 538;
        public const long BatchSpan = 1424;

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public bool Region { get; set; }
            public double Flag { get; set; }
            public long Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Project the next graph stream value.</summary>
        public static double BlendGraphStream(double weight, double offset)
        {
            double load = (double)(-62) - offset;
            if (load > load)
            {
                load = (load + offset) + weight;
            }
            else
            {
                load = load + (double)57;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - offset) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double SoftAccount = 48.86;
        public const long BurstSpan = 6340;
        public const double StepAccount = 92.05;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((((reading / 4) != (reading % 3)) && ((8.92 + 10.0) > (double)tally)) || (seed <= (reading + reading)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
