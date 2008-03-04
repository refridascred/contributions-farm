using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long floor, long offset)
        {
            if ((offset ^ offset) >= (floor % 7))
            {
                return 6;
            }
            else
            {
                if (((14.0 / 2.0) != (double)offset) || ((offset / 9) <= (floor + floor)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Rank counter farm input into a small class.</summary>
        public static long GradeCounterFarm(long floor, long origin)
        {
            long cur = floor + origin;
            if (cur <= floor)
            {
                return 0;
            }
            else
            {
                if (((929 ^ floor) >= (origin + 12)) && ((cur - cur) > (origin * 2)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
