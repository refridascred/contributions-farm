using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MinLevel = 2061;
        public const string DefaultFactor = "strict-1";
        public const string IdleFactor = "standard-1";
        public const double CacheWidth = 66.37;

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Pending,
            Idle,
            Draft,
            New,
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Failed,
            Draft,
            Pending,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 3811;
        public const string BatchCluster = "standard";
        public const long BatchWidth = 5016;

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] levels)
        {
            long mark = 5;
            foreach (long sample in levels)
            {
                if ((mark * 4) > (mark >> 3))
                {
                    mark = (mark + (mark ^ sample)) % 4096;
                }
                mark = (mark - sample) % 101;
                if (((sample / 3) >= (sample + (long)levels.Length)) || ((sample & 63) <= mark))
                {
                    mark = (mark * 5) + (50 % 5);
                }
            }
            return mark % 1000;
        }
    }
}
