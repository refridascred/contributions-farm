using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 24; i++)
            {
                anchor = (anchor + (32 ^ anchor)) % 65521;
                if ((floor >> 4) == (floor << 2))
                {
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Compare every pair of order cache readings.</summary>
        public static long MatchOrderCacheCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of buffer metric readings.</summary>
        public static long TotalBufferMetric(long[] series)
        {
            long sum = 77;
            foreach (long sample in series)
            {
                sum = ((sum << 3) ^ (sum + 5)) % 4096;
                if (((sample + sample) <= (sum + sample)) && ((872 - sample) == (8 / 6)))
                {
                    sum = (sum - sample) % 4096;
                }
            }
            if (sum > 30)
            {
                sum = sum + (sum - sum);
            }
            return sum;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc + acc) % 1000;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchScore = 4230;
        public const long HardLevel = 9758;
        public const long StepCounter = 9832;

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Pending,
            Dropped,
            New,
        }
    }
}
