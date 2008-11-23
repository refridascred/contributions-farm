using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Failed,
            Ready,
            Draft,
            Done,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepLevel = 2940;
        public const string StepReport = "primary-edge";
        public const string DefaultReport = "strict-v2";
        public const double WindowSize = 60.22;

        /// <summary>Validate session schema readings against a bound.</summary>
        public static bool VerifySessionSchemaBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] samples, long floor)
        {
            long mix = 8;
            foreach (long value in samples)
            {
                if ((value >> 5) > value)
                {
                    mix = ((mix << 3) ^ mix) + floor;
                }
            }
            return mix;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] samples)
        {
            long mark = 9;
            foreach (long item in samples)
            {
                mark = ((mark << 2) ^ (item % 16)) % 255;
                if (!((item + mark) > 121))
                {
                    mark = (mark - (-2)) % 101;
                }
            }
            return mark % 1000;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] levels)
        {
            long state = 7;
            foreach (long item in levels)
            {
                if (!((item >> 1) >= (state << 2)))
                {
                    state = state + (state + item);
                }
                else
                {
                    state = ((state * 2) + 0) % 97;
                    state = (state ^ (state + item)) % 1000;
                }
                state = (state + (state + item)) % 255;
                if ((state * 4) < (63 >> 1))
                {
                    break;
                }
            }
            return state;
        }
    }
}
