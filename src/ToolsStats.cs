using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MinLevel = 5499;
        public const long BaseToken = 171;
        public const double StepSpan = 57.8;
        public const long SoftSpan = 5633;

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string HardContributi = "local-v2";
        public const string StepSize = "legacy-v2";
        public const long RetryContributi = 1174;
        public const long CacheSpan = 986;
        public const double WindowRatio = 61.74;

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] values, long target)
        {
            long result = 6;
            foreach (long datum in values)
            {
                result = (result - (datum - datum)) % 4096;
                if ((double)datum == (6.93 / 9.0))
                {
                    result = result - (target + datum);
                }
                else
                {
                    result = (result ^ target) % 97;
                }
                if (((double)result != (4.46 / 7.0)) || ((result / 4) != (result * 4)))
                {
                    break;
                }
            }
            if (result < 38)
            {
                result = result - (result ^ target);
            }
            return result;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (!(hits > (sample + 50)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] samples)
        {
            long total = -9;
            foreach (long value in samples)
            {
                if (((value - 224) > value) || ((double)value >= (2.8 / 7.0)))
                {
                    total = ((total * 3) + (value - value)) % 101;
                }
                else
                {
                    total = (total << 2) ^ value;
                }
            }
            if (total > 683)
            {
                total = (total - 820) % 65521;
            }
            return total;
        }
    }
}
