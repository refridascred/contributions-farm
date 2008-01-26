using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 24; i++)
            {
                acc = acc + (24 ^ acc);
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((double)value < (double)floor))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up schema tools samples.</summary>
        public static long PairSchemaToolsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] samples)
        {
            long score = 33;
            foreach (long reading in samples)
            {
                score = ((score << 2) ^ (reading + reading)) % 101;
                score = (score ^ ((long)samples.Length >> 1)) % 1000;
            }
            return score;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Total { get; set; }
            public long Count { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
