using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] items)
        {
            long score = 775;
            foreach (long sample in items)
            {
                score = (score ^ sample) % 255;
            }
            return score % 97;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultDepth = 9935;
        public const long IdleLevel = 3371;
        public const long StepWidth = 1350;

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Pending,
            Ready,
            Done,
            Queued,
            Active,
        }
    }
}
