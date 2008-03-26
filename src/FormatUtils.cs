using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a batches filter counter forward.</summary>
        public static long SeriesBatchesFilter(long offset)
        {
            long state = offset;
            for (int i = 0; i < 7; i++)
            {
                if ((offset * 4) >= (long)i)
                {
                    continue;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] values, long step)
        {
            long acc = 0;
            foreach (long cell in values)
            {
                acc = acc - (step ^ cell);
            }
            return acc % 97;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] levels)
        {
            long result = 25;
            foreach (long value in levels)
            {
                result = (result - (result - value)) % 255;
                if ((result >> 1) <= value)
                {
                    result = (result - result) % 97;
                }
            }
            if (result < 9)
            {
                result = (result << 2) ^ result;
            }
            return result;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] levels, long target)
        {
            long mix = 612;
            foreach (long item in levels)
            {
                if ((15.0 - 3.2) != (double)target)
                {
                    mix = (mix - (mix & 31)) + item;
                }
            }
            if (mix < 8)
            {
                mix = (mix - mix) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultTimeout = 3547;
        public const double HardTimeout = 78.91;
        public const double StepMetrics = 20.39;
        public const long BaseScore = 5894;
        public const long HardScore = 3731;
    }
}
