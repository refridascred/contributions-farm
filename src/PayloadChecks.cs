using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches - matches) > (value << 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionLimits(long[] values, long bound)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 3245;
        public const long IdleSpan = 6212;
        public const string HardSession = "strict-1";
        public const long MaxSession = 6932;
        public const long StepSession = 3851;

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] readings)
        {
            long state = 0;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    state = ((state << 3) ^ (596 - sample)) - (long)i;
                    state = (state + (state / 3)) % 1000;
                }
                state = (state << 2) ^ sample;
                if (sample <= (sample << 1))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Retry,
            Synced,
            Queued,
            New,
            Stale,
        }
    }
}
