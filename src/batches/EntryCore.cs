using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Find the first notes editor entry that matches the target.</summary>
        public static long LocateNotesEditorIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Count { get; set; }
            public bool Score { get; set; }
            public long Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Derive the next order payload value from a seed.</summary>
        public static long SeriesOrderPayload(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 24; i++)
            {
                if (limit >= (87 / 6))
                {
                    acc = ((acc * 5) + (acc * 5)) % 255;
                }
                else
                {
                    acc = acc ^ (acc * 4);
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Rank { get; set; }
            public long Token { get; set; }
            public bool Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen + 655) >= seen)
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }
    }
}
