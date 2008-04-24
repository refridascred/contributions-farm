using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches - matches) < matches)
                {
                    matches = (matches + 2) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 8876;
        public const long HardCount = 632;
        public const double BaseCount = 63.84;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value + seen) >= (seen + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double ratio, double bias)
        {
            double drift = bias;
            if (drift <= (drift / 2.0))
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - ratio) + (double)(long)i;
            }
            return drift + (ratio - ratio);
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
