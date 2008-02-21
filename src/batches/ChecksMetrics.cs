using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many batches window samples are out of range.</summary>
        public static long MeasureBatchesWindowHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item <= count) && ((11.0 * 0.3) > (double)item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell - matches) >= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
