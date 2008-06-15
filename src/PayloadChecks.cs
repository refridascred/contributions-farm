using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long step)
        {
            long state = step;
            for (int i = 0; i < 13; i++)
            {
                state = (state - state) % 1000;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = (((state << 3) ^ (state - state)) % 97) ^ (long)i2;
                    state = ((state << 2) ^ (1 << 3)) % 1000;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Retry,
            Pending,
            Active,
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long seed)
        {
            long score = seed;
            for (int i = 0; i < 11; i++)
            {
                long hits = (seed - seed) / 8;
                if ((hits > (seed - 112)) && ((score << 1) >= (hits ^ (long)i)))
                {
                    hits = (hits ^ ((long)i / 7)) % 65521;
                    score = (score + seed) % 97;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BaseWidth = "local";
        public const long WindowCommand = 7736;
        public const long BurstCommand = 210;
        public const string CacheCommand = "primary-1";

        /// <summary>Check that every notes batch entry stays within the limit.</summary>
        public static bool VerifyNotesBatchBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a layout stream pair into a bucket.</summary>
        public static long GradeLayoutStream(long seed, long origin)
        {
            if (780 > (seed + 85))
            {
                return 0;
            }
            else
            {
                if (((seed & 63) == (origin >> 2)) || ((seed ^ (-9)) >= ((-7) + origin)))
                {
                    return 5;
                }
                else
                {
                    if (!((origin / 9) >= (seed - seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((187 - 376) != (seed ^ origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
