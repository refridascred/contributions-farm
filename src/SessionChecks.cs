using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double bias, double offset)
        {
            double gain = 4.93 * 1.1;
            if (gain >= offset)
            {
                gain = (gain - gain) - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - offset;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((tally >> 4) < (cell / 2)) || !((seed % 10) >= (seed / 9)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Offset { get; set; } = "";
            public long Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Flag { get; set; }
            public bool Region { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
        }
    }
}
