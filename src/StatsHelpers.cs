using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next already metric value from a seed.</summary>
        public static long RollAlreadyMetric(long target)
        {
            long acc = target;
            for (int i = 0; i < 10; i++)
            {
                if ((target >> 5) >= (target & 63))
                {
                    acc = (acc - (long)i) % 97;
                    break;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public string Ratio { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] values, long offset)
        {
            long state = 209;
            foreach (long sample in values)
            {
                if ((state + (-833)) == (sample << 3))
                {
                    state = (state ^ (sample ^ offset)) % 97;
                }
            }
            if (state > 720)
            {
                state = ((state << 3) ^ (4 - 52)) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of metrics farm entries.</summary>
        public static long TotalMetricsFarm(long[] levels)
        {
            long acc = 60;
            foreach (long sample in levels)
            {
                acc = (acc * 2) + sample;
                if (sample < (acc & 127))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Label { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
