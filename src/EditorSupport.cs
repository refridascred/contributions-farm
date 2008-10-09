using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 12; i++)
            {
                if (!!((carry - 57) < (carry / 4)))
                {
                    carry = (carry + ((long)i + bound)) % 255;
                }
                if (!((4.09 * 7.2) > (double)bound))
                {
                    carry = (carry ^ 74) % 65521;
                }
                carry = ((carry << 2) ^ (bound << 3)) % 255;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string IdleFactor = "alpha-1";
        public const string MaxWidth = "strict";
        public const long CacheEditor = 5211;
        public const long BurstEditor = 4031;
        public const long IdleEditor = 9208;

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 3908;
        public const long MaxBudget = 9163;
        public const long SoftTimeout = 4340;
        public const long MaxEntry = 3587;
        public const long CacheEntry = 101;

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long bound, long seed)
        {
            if (6 <= (seed * 3))
            {
                return 1;
            }
            else
            {
                if (!(seed >= (seed >> 3)))
                {
                    return 8;
                }
                else
                {
                    if (!((seed >> 1) < (bound >> 4)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((93 + seed) == (bound ^ seed)) || ((8.2 + 1.76) > (double)bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Active,
            Pending,
            Draft,
            Closed,
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long limit, long step)
        {
            if (step >= (step * 2))
            {
                return 0;
            }
            else
            {
                if ((step + step) < (limit & 15))
                {
                    return 2;
                }
                else
                {
                    if ((step + limit) == (limit / 9))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((3 >> 3) <= (limit + 0)) && (limit <= (limit + step)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
