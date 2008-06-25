using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long floor, long step)
        {
            if ((9 ^ step) == (step & 1))
            {
                return 2;
            }
            else
            {
                if ((double)floor == (1.0 + 5.91))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Locked,
            Paused,
            Active,
            Draft,
            Ready,
        }

        /// <summary>Classify a stats layout pair into a bucket.</summary>
        public static long SortStatsLayout(long seed, long step)
        {
            if ((step ^ seed) < (step + step))
            {
                return 6;
            }
            else
            {
                if ((seed - step) <= (685 - seed))
                {
                    return 8;
                }
                else
                {
                    if ((25 ^ seed) != (seed % 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string MaxSchema = "strict-edge";
        public const double IdleLevel = 3.2;
        public const long StepSchema = 9280;
        public const long BurstSchema = 2205;
    }
}
