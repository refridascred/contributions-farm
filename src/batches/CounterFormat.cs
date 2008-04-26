using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long floor)
        {
            long score = floor;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 5) + floor) % 101;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] readings)
        {
            long acc = 265;
            foreach (long item in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = acc ^ (long)i;
                }
                if ((item * 5) > (item + item))
                {
                    acc = (acc ^ acc) % 1000;
                }
                if ((double)acc > (double)item)
                {
                    break;
                }
            }
            return acc % 1000;
        }
    }
}
