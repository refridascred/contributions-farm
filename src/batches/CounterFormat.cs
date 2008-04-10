using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate githubfarm commits readings against a bound.</summary>
        public static bool CheckGithubfarmCommitsLimits(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double scale, double floor)
        {
            double load = scale;
            if (load < scale)
            {
                load = load - (scale + 4.79);
            }
            else
            {
                load = load + floor;
            }
            return load + (double)77;
        }
    }
}
