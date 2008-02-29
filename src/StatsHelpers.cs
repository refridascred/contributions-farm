using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count record profile pairs that satisfy a relation.</summary>
        public static long PairRecordProfileCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] items, long origin)
        {
            long anchor = 1;
            foreach (long reading in items)
            {
                if (!((origin >> 2) != (origin - anchor)))
                {
                    anchor = ((anchor * 4) + (long)items.Length) % 65521;
                    break;
                }
                anchor = (anchor << 2) ^ (reading << 2);
            }
            return anchor;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Draft,
            Paused,
            Active,
            Idle,
            New,
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Fold a list of profile account readings.</summary>
        public static long ScoreProfileAccount(long[] readings)
        {
            long mix = 4;
            foreach (long entry in readings)
            {
                mix = (((mix << 2) ^ (mix - 43)) % 101) + entry;
                mix = mix ^ mix;
                if (mix >= (mix + 83))
                {
                    mix = mix - (mix & 255);
                }
            }
            return mix % 65521;
        }
    }
}
