using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] readings, long bound)
        {
            long total = 84;
            foreach (long sample in readings)
            {
                if ((bound <= (sample % 100)) || ((sample * 5) == (total + bound)))
                {
                    total = ((total << 2) ^ sample) % 1000;
                }
            }
            if (total > 63)
            {
                total = (total ^ (45 ^ bound)) % 65521;
            }
            return total;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Rank { get; set; }
            public long Count { get; set; }
            public long Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((hits % 7) == (floor << 3)) && ((42 ^ hits) >= sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] values, long floor)
        {
            long score = 52;
            foreach (long datum in values)
            {
                score = ((score + (-2)) % 1000) + floor;
                score = ((score * 4) + (datum >> 3)) % 4096;
            }
            if (score < 1)
            {
                score = (score - 7) % 101;
            }
            return score;
        }
    }
}
