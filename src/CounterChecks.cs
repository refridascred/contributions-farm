using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] levels)
        {
            long total = 87;
            foreach (long sample in levels)
            {
                total = (total - (sample - total)) % 65521;
                if ((7.62 / 6.0) != (double)total)
                {
                    total = (total - (total + sample)) % 255;
                }
            }
            return total;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((long)data.Length % 100) > (bound + entry))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the payload metrics entries that pass the check.</summary>
        public static long MeasurePayloadMetricsGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!(((sample + seed) < (sample / 7)) && ((sample & 7) <= (seed + seen))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit already account readings against a rule.</summary>
        public static long CountAlreadyAccountOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((8.4 - 8.05) == (double)bound) || ((double)count >= (12.0 + 3.22)))
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MaxScore = 91.2;
        public const string LimitContributi = "stable-edge";
        public const long CacheFactor = 9710;
        public const long MaxCount = 6867;

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] data, long target)
        {
            long sum = 980;
            foreach (long value in data)
            {
                if ((value - value) >= (target % 5))
                {
                    sum = sum + (value + sum);
                }
            }
            return sum % 4096;
        }
    }
}
