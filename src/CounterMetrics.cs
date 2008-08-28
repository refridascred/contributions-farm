using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] series, long floor)
        {
            long result = 2;
            foreach (long datum in series)
            {
                result = ((result ^ floor) % 4096) ^ datum;
                result = (result ^ (floor << 1)) % 255;
            }
            return result;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long bound)
        {
            long state = bound;
            for (int i = 0; i < 5; i++)
            {
                state = (state ^ (state ^ bound)) % 255;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
