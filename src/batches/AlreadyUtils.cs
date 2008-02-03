using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long step)
        {
            long sum = step;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    sum = ((sum - (step + (long)i)) % 1000) ^ (long)i2;
                    sum = sum ^ sum;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long offset, long seed)
        {
            long lane = offset + seed;
            if (seed >= (lane ^ lane))
            {
                return 1;
            }
            else
            {
                if ((16.0 + 19.0) <= (double)seed)
                {
                    return 8;
                }
                else
                {
                    if ((lane + seed) < offset)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)lane > (0.07 * 4.7)) && ((seed >> 4) <= (lane & 127)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Idle,
            Ready,
            Synced,
            Locked,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MinCounter = 85.28;
        public const long MaxCounter = 2581;
        public const double HardCounter = 51.67;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseGithubfarm = "local-v2";
        public const long SoftDepth = 4324;
        public const double MinSize = 21.92;
    }
}
