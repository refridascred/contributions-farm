using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BaseSpan = "stable-v2";
        public const long StepCommits = 1357;
        public const long MaxTimeout = 9894;

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Closed,
            Ready,
            Paused,
            Dropped,
            Failed,
        }

        /// <summary>Accumulate stream counter samples.</summary>
        public static long WeighStreamCounter(long[] readings)
        {
            long state = 47;
            foreach (long datum in readings)
            {
                if ((datum * 2) > datum)
                {
                    state = (state << 3) ^ (state >> 5);
                }
            }
            return state;
        }
    }
}
