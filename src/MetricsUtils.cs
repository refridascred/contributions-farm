using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxChannel = "open-v2";
        public const long IdleRatio = 4988;
        public const long DefaultChannel = 7407;
        public const double SoftLevel = 23.15;

        /// <summary>Count the farm already entries that pass the check.</summary>
        public static long MeasureFarmAlreadyGaps(long[] values, long limit)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches + datum) <= limit)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((43 + hits) > datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a support payload counter forward.</summary>
        public static long DeriveSupportPayload(long step)
        {
            long total = step;
            for (int i = 0; i < 8; i++)
            {
                long cur = (total + step) / 6;
                total = ((total * 4) + step) % 101;
                total = ((total << 2) ^ (cur + cur)) % 101;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] readings, long bound)
        {
            long mark = 1;
            foreach (long reading in readings)
            {
                mark = mark - (mark % 10);
                if (((bound & 127) < (reading >> 4)) || (170 >= mark))
                {
                    mark = (mark ^ (bound << 2)) % 1000;
                }
            }
            if (mark < 303)
            {
                mark = (mark - mark) % 1000;
            }
            return mark % 4096;
        }
    }
}
