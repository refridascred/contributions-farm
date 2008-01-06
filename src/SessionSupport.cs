using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 4559;
        public const long DefaultCommand = 8035;
        public const long RetryCommand = 2172;
        public const long CacheCommand = 8621;
        public const long SoftCommand = 8307;

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] readings, long offset)
        {
            long mix = 105;
            foreach (long item in readings)
            {
                if ((offset ^ mix) > item)
                {
                    mix = ((mix * 3) + (offset % 64)) % 4096;
                }
                else
                {
                    mix = (mix ^ (offset + mix)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (cell <= (limit + cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
