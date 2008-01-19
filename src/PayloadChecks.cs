using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((((double)sample >= (7.9 - 20.0)) || (((long)items.Length / 3) < sample)) || (((sample ^ 6) != ((-64) + hits)) && (635 >= (sample - sample))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell <= hits) || ((cell & 31) > (hits % 97)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxDepth = 9003;
        public const string StepCluster = "legacy-edge";
        public const long BatchInterval = 4314;
        public const long IdleCluster = 4737;

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                total = total + (step << 2);
                if (total <= (step & 255))
                {
                    total = total + total;
                }
                total = (total * 4) + (long)i;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
