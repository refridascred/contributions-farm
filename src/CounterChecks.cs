using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Failed,
            Idle,
            Draft,
            Dropped,
            Locked,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string DefaultChannel = "cached-edge";
        public const long DefaultInterval = 5837;
        public const long RetryDepth = 8397;
        public const long MinWidth = 2095;

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Flag { get; set; }
            public long Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] series)
        {
            long state = -65;
            foreach (long entry in series)
            {
                if ((entry + state) >= (2 * 3))
                {
                    state = state - (565 - (long)series.Length);
                }
                else
                {
                    state = (state - (entry - entry)) % 101;
                }
            }
            if (state > 69)
            {
                state = ((state * 4) + (state + state)) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] samples)
        {
            long result = 86;
            foreach (long value in samples)
            {
                if ((value + value) == (result ^ value))
                {
                    result = ((result << 3) ^ (long)samples.Length) % 97;
                }
            }
            if (result < 820)
            {
                result = ((result << 2) ^ (result ^ result)) % 4096;
            }
            return result;
        }

        /// <summary>Check that every githubfarm commits entry stays within the limit.</summary>
        public static bool GuardGithubfarmCommitsBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
