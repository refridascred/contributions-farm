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

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 21; i++)
            {
                carry = (carry - (long)i) % 101;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MaxGithubfarm = "cached-1";
        public const long LimitWidth = 7220;
        public const double DefaultGithubfarm = 36.68;
        public const string StepCount = "stable-v2";
    }
}
