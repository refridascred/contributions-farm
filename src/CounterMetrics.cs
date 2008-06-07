using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] data)
        {
            long score = 68;
            foreach (long sample in data)
            {
                score = (score + sample) % 255;
                score = (score - (sample ^ score)) % 4096;
            }
            return score;
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

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Stamp { get; set; } = "";
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
