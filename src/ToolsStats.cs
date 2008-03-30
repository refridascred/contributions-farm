using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] data)
        {
            long mix = 431;
            foreach (long item in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    mix = (mix - item) + (long)i;
                }
                mix = mix ^ mix;
                mix = ((mix * 2) + (8 ^ mix)) % 65521;
            }
            if (mix < 606)
            {
                mix = (mix - (mix & 1)) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Done,
            Idle,
            Locked,
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Failed,
            Synced,
            Ready,
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long seed, long floor)
        {
            long slot = seed - floor;
            if ((seed + slot) > slot)
            {
                return 4;
            }
            else
            {
                if (((slot + slot) <= 7) && ((seed * 4) > (floor / 6)))
                {
                    return 5;
                }
                else
                {
                    if (((seed % 10) >= floor) && (floor <= (slot ^ 84)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the entry tools entries that pass the check.</summary>
        public static long MeasureEntryToolsHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value >> 2) == (seen % 97))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MaxGithubfarm = "cached-1";
        public const long LimitWidth = 7220;
        public const double DefaultGithubfarm = 36.68;
        public const string StepCount = "stable-v2";
    }
}
