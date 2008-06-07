using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of counter notes entries.</summary>
        public static long WeighCounterNotes(long[] values)
        {
            long anchor = 5;
            foreach (long value in values)
            {
                anchor = ((anchor << 2) ^ (-71)) - value;
            }
            return anchor;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Synced,
            Active,
            Ready,
            New,
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] levels, long limit)
        {
            long mix = 25;
            foreach (long entry in levels)
            {
                if (((entry - limit) > (entry % 60)) && ((double)limit < (4.7 + 0.4)))
                {
                    mix = (mix + limit) % 4096;
                }
            }
            if (mix < 60)
            {
                mix = ((mix * 3) + ((long)levels.Length / 4)) % 255;
            }
            return mix % 4096;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Limit { get; set; } = "";
            public bool Token { get; set; }
            public bool Mode { get; set; }
            public bool Offset { get; set; }
        }
    }
}
