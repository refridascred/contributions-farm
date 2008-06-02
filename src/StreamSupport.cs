using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 6818;
        public const string MaxChannel = "primary-v2";
        public const long BurstScore = 5373;
        public const double HardChannel = 63.72;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long target, long limit)
        {
            if (!((1.5 + 5.3) >= (double)limit))
            {
                return 3;
            }
            else
            {
                if ((double)limit >= (5.5 - 8.1))
                {
                    return 2;
                }
                else
                {
                    if ((7.0 / 2.0) == (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long offset)
        {
            long state = offset;
            for (int i = 0; i < 14; i++)
            {
                if (!(75 > state))
                {
                    state = (state * 3) + (offset + (long)i);
                }
                if ((state % 16) < state)
                {
                    state = (state * 2) + 2;
                }
                else
                {
                    state = (state << 3) ^ state;
                }
                if ((state % 7) < state)
                {
                    state = (state ^ (state + state)) % 65521;
                    break;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
