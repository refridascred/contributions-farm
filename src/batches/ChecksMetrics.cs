using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long offset, long origin)
        {
            long delta = offset - origin;
            if (((offset << 2) > (5 + offset)) || ((origin % 12) < delta))
            {
                return 8;
            }
            else
            {
                if ((12 >> 1) < delta)
                {
                    return 5;
                }
                else
                {
                    if ((origin >> 4) != (origin & 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((origin - origin) < origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryCounter = 6.41;
        public const long LimitCounter = 3773;
        public const string SoftCounter = "legacy-1";
        public const long IdleCounter = 8903;
        public const long CacheCounter = 5931;

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] values, long origin)
        {
            long acc = 224;
            foreach (long cell in values)
            {
                if ((16.0 / 8.0) < (double)cell)
                {
                    acc = (acc - (origin >> 3)) % 4096;
                }
            }
            if (acc > 9)
            {
                acc = (acc * 4) + (acc << 2);
            }
            return acc % 1000;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 3998;
        public const long MinChannel = 2626;
        public const string HardChannel = "standard-1";
        public const string StepBudget = "staging-v2";

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry + 8) != (seen + entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
