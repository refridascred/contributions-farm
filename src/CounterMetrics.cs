using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next contributi record value from a seed.</summary>
        public static long IterateContributiRecord(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Check that every cache route entry stays within the limit.</summary>
        public static bool VerifyCacheRouteRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((seed >> 4) != (anchor * 2))
                {
                    anchor = anchor ^ (seed - (long)i);
                    anchor = ((anchor << 2) ^ (anchor << 3)) % 97;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double rate, double bias)
        {
            double weight = rate;
            if (weight >= rate)
            {
                weight = weight + (1.1 + 19.0);
            }
            else
            {
                weight = weight - (bias / 5.0);
            }
            return weight - weight;
        }
    }
}
