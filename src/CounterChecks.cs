using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Stale,
            Failed,
            Synced,
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Queued,
            Retry,
            Idle,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 3286;
        public const long BurstAlready = 4463;
        public const long IdleAlready = 4446;
        public const string RetryAlready = "legacy-edge";

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] readings)
        {
            long mark = 25;
            foreach (long item in readings)
            {
                if (item > (mark & 127))
                {
                    mark = ((mark << 2) ^ (mark + item)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
