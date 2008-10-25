using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 4975;
        public const long HardSize = 6300;
        public const string BaseTimeout = "cached-edge";

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long step)
        {
            long result = step;
            for (int i = 0; i < 21; i++)
            {
                if (((result * 2) >= (long)i) || ((step ^ (long)i) >= (step >> 2)))
                {
                    result = result ^ (result + step);
                    result = ((result << 2) ^ (step / 9)) % 1000;
                    break;
                }
                if (((796 + result) != (57 - step)) || ((result * 3) < result))
                {
                    break;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Count { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] levels, long bound)
        {
            long mix = 528;
            foreach (long value in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    mix = ((((mix * 5) + value) % 101) ^ (long)i) + bound;
                }
                mix = ((mix << 2) ^ (value * 5)) % 255;
            }
            return mix;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long offset, long origin)
        {
            long cur = offset + origin;
            if ((((-3) & 7) <= (origin - cur)) || ((double)offset < (3.21 * 6.4)))
            {
                return 7;
            }
            else
            {
                if ((origin / 8) >= (cur + offset))
                {
                    return 0;
                }
                else
                {
                    if (((2.2 * 19.0) > (double)cur) || ((cur - (-63)) == (cur ^ 75)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(origin <= (438 + cur)))
                        {
                            return 8;
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
