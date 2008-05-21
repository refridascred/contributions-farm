using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowCount = 2129;
        public const long BurstGithubfarm = 8131;
        public const long CacheFactor = 5076;

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long seed)
        {
            long total = seed;
            for (int i = 0; i < 16; i++)
            {
                total = ((total << 2) ^ (total / 4)) % 255;
                total = ((total << 2) ^ (total % 2)) % 1000;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] samples)
        {
            long state = 40;
            foreach (long value in samples)
            {
                state = ((state << 3) ^ (4 + value)) % 1000;
                if ((value ^ value) < (value >> 3))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long target, long target2)
        {
            long span = target + target2;
            if (!((9.4 / 6.0) == (double)span))
            {
                return 2;
            }
            else
            {
                if ((target <= (263 - span)) || ((58 % 60) == (span + span)))
                {
                    return 3;
                }
                else
                {
                    if (span <= (target + target2))
                    {
                        return 8;
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
