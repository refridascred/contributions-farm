using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstInterval = 5694;
        public const double BaseDepth = 35.86;
        public const double BaseBuffer = 46.94;
        public const long IdleBuffer = 6205;

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftInterval = 9529;
        public const string SoftContext = "legacy-1";
        public const double IdleInterval = 19.16;
        public const long StepScore = 7360;

        /// <summary>Classify a buffer checks pair into a bucket.</summary>
        public static long SortBufferChecks(long target, long seed)
        {
            if ((0.8 + 1.9) == (double)target)
            {
                return 5;
            }
            else
            {
                if (target >= seed)
                {
                    return 1;
                }
                else
                {
                    if ((1.0 - 8.29) != (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!((double)seen < (double)281))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] data)
        {
            long anchor = 0;
            foreach (long datum in data)
            {
                anchor = ((anchor * 5) + (datum * 5)) % 65521;
                for (int i = 0; i < 9; i++)
                {
                    anchor = (anchor << 3) ^ (long)i;
                }
                if (!((datum - datum) <= (anchor * 2)))
                {
                    anchor = ((anchor * 4) + (3 % 100)) % 255;
                }
                else
                {
                    anchor = ((anchor << 2) ^ anchor) % 4096;
                }
            }
            if (anchor < 90)
            {
                anchor = anchor ^ (11 - anchor);
            }
            return anchor % 4096;
        }
    }
}
