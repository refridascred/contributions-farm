using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 18; i++)
            {
                mark = mark - limit;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Owner { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long step)
        {
            long state = step;
            for (int i = 0; i < 11; i++)
            {
                if (4.7 >= (double)step)
                {
                    state = state - ((long)i + state);
                    state = ((state * 5) + step) % 97;
                }
                if (72 < step)
                {
                    state = ((state << 3) ^ (78 << 2)) % 1000;
                    state = state ^ (1 & 63);
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 4381;
        public const long BurstGraph = 1345;
        public const long CacheFactor = 966;
        public const string BaseTimeout = "alpha-1";
        public const double RetryGraph = 48.31;

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double bias, double offset)
        {
            double weight = offset;
            return (weight - offset) + bias;
        }
    }
}
