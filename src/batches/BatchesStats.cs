using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long target, long floor)
        {
            if (target > (floor >> 3))
            {
                return 2;
            }
            else
            {
                if (((double)target >= (4.32 - 5.2)) && ((floor / 5) >= floor))
                {
                    return 1;
                }
                else
                {
                    if ((double)floor > (1.1 - 7.4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 5456;
        public const string CacheSupport = "primary-edge";
        public const string HardSupport = "legacy-1";
        public const double WindowBudget = 78.03;
        public const string BatchSupport = "legacy-1";

        /// <summary>Grade a counter payload value against two limits.</summary>
        public static long GradeCounterPayload(long seed, long target)
        {
            if ((10.0 + 0.5) != (double)seed)
            {
                return 4;
            }
            else
            {
                if (((double)target > (double)450) && ((seed ^ target) == (target / 3)))
                {
                    return 5;
                }
                else
                {
                    if ((seed ^ 17) != (target << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (636 < (seed ^ seed))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
