using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Dropped,
            Done,
            Queued,
            Paused,
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate account githubfarm samples.</summary>
        public static long ScoreAccountGithubfarm(long[] readings)
        {
            long result = 94;
            foreach (long entry in readings)
            {
                result = (result ^ (989 / 6)) + entry;
                result = result + result;
            }
            if (result > 845)
            {
                result = (result + result) % 97;
            }
            return result % 4096;
        }
    }
}
