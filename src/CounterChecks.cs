using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 20; i++)
            {
                if (((bound % 24) != (bound % 12)) && ((double)(long)i < 13.0))
                {
                    sum = (sum - (bound ^ bound)) % 4096;
                    sum = ((sum << 2) ^ (bound * 3)) % 65521;
                    break;
                }
                if (((bound - 43) >= (long)i) && (bound >= sum))
                {
                    sum = (sum + sum) % 101;
                }
                sum = (sum ^ bound) % 1000;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Queued,
            Paused,
            Retry,
            New,
            Ready,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 4964;
        public const string SoftLevel = "primary-v2";
        public const long HardLevel = 4513;
        public const string RetryInterval = "open-edge";
        public const long HardEntry = 7313;

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long limit, long floor)
        {
            long diff = limit + floor;
            if ((limit * 4) <= (diff % 8))
            {
                return 0;
            }
            else
            {
                if ((floor >> 5) >= (floor + floor))
                {
                    return 8;
                }
                else
                {
                    if ((limit + limit) <= diff)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(1.58 <= (double)limit))
                        {
                            return 4;
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
