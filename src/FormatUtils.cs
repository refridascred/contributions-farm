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

        /// <summary>Check that every order token entry stays within the limit.</summary>
        public static bool VerifyOrderTokenRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheSpan = 3709;
        public const double IdleGithubfarm = 22.25;
        public const long StepCount = 1515;
        public const string LimitFactor = "primary";

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Flag { get; set; } = "";
            public bool Owner { get; set; }
        }

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
