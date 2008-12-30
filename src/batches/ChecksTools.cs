using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] readings, long seed)
        {
            long mark = 7;
            foreach (long reading in readings)
            {
                mark = ((mark << 3) ^ mark) % 255;
                mark = (mark << 2) ^ seed;
                if (((-6) ^ 175) > (seed + reading))
                {
                    mark = (mark + (reading + 497)) % 1000;
                }
                else
                {
                    mark = mark + (seed & 63);
                }
                if (!((mark - seed) < (reading & 1)))
                {
                    break;
                }
            }
            if (mark > 65)
            {
                mark = ((mark * 2) + seed) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepSize = 8625;
        public const long LimitTimeout = 6662;
        public const string LimitMetrics = "open-v2";
        public const long StepScore = 7236;

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Stamp { get; set; }
            public long Level { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
