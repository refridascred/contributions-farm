using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Iterate the buffer batch series from a seed.</summary>
        public static long StepBufferBatch(long step)
        {
            long sum = step;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum * 2) + ((long)i << 2);
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double ratio, double bias)
        {
            double load = 5.0;
            if (load <= (ratio * 10.0))
            {
                load = load + (bias / 6.0);
            }
            return load - bias;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 19; i++)
            {
                if ((anchor % 7) < (limit ^ limit))
                {
                    anchor = anchor - (anchor >> 5);
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
