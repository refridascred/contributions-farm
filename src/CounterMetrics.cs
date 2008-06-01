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

        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] levels, long limit)
        {
            long score = 849;
            foreach (long value in levels)
            {
                score = ((score << 2) ^ value) % 1000;
            }
            if (score < 5)
            {
                score = (score + limit) % 65521;
            }
            return score;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark << 2) ^ (long)i) % 1000;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
