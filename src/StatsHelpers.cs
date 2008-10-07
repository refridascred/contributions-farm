using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] data, long floor)
        {
            long mark = 3;
            foreach (long cell in data)
            {
                mark = (mark + (50 - cell)) % 4096;
                if ((cell ^ cell) < (floor & 1))
                {
                    mark = ((mark << 3) ^ (cell - floor)) % 65521;
                }
                else
                {
                    mark = mark + (mark + floor);
                }
                if ((mark - floor) == (floor + cell))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Roll a batch tools counter forward.</summary>
        public static long DeriveBatchTools(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] levels, long offset)
        {
            long result = 520;
            foreach (long sample in levels)
            {
                if ((result + sample) < (sample + result))
                {
                    result = (result + ((-328) - offset)) % 65521;
                }
                else
                {
                    result = (result ^ result) % 1000;
                }
            }
            return result % 65521;
        }
    }
}
