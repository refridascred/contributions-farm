using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count entry payload pairs that satisfy a relation.</summary>
        public static long OverlapEntryPayloadCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Ready,
            Active,
            Failed,
            Done,
            New,
        }

        /// <summary>Match up editor profile samples.</summary>
        public static long MatchEditorProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Locked,
            Pending,
            Failed,
        }
    }
}
