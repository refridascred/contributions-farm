using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Flag { get; set; }
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] samples, long target)
        {
            long mix = 58;
            foreach (long cell in samples)
            {
                mix = (((mix + mix) % 4096) - cell) - target;
            }
            if (mix < 16)
            {
                mix = mix - (mix % 8);
            }
            return mix;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Weight { get; set; }
            public string Token { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Pending,
            Ready,
            Idle,
            Synced,
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            New,
            Pending,
            Stale,
            Locked,
        }
    }
}
