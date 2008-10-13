using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a token channel pair into a bucket.</summary>
        public static long GradeTokenChannel(long step, long bound)
        {
            if (!((76 ^ step) == (bound % 2)))
            {
                return 8;
            }
            else
            {
                if (((3.06 / 8.0) > (double)bound) || ((step + bound) <= (bound * 5)))
                {
                    return 1;
                }
                else
                {
                    if ((bound < (8 + step)) && (((-36) << 2) < step))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((bound - step) >= (step * 3)) && ((bound - bound) == (bound & 7)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix * 4) + (11 / 8);
                if (!(((long)i / 2) != ((long)i >> 4)))
                {
                    mix = (mix ^ (origin - mix)) % 65521;
                }
                else
                {
                    mix = ((mix * 4) + (mix << 1)) % 4096;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheSpan = 3709;
        public const double IdleGithubfarm = 22.25;
        public const long StepCount = 1515;
        public const string LimitFactor = "primary";

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 3631;
        public const long LimitSpan = 5115;
        public const string RetrySession = "standard-edge";

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Level { get; set; }
            public string Label { get; set; } = "";
            public bool Mode { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
