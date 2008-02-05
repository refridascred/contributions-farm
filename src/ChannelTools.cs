using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double MinLevel = 25.35;
        public const long WindowSpan = 1611;
        public const long LimitToken = 4445;
        public const long SoftToken = 1467;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen * 5) > reading)
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 4627;
        public const long LimitEditor = 1345;
        public const long StepCount = 6917;
    }
}
