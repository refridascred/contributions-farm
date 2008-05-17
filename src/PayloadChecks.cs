using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountHits(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!(((2 / 9) < (origin + 435)) || (datum >= (datum / 8))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (bound < (sample * 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long MatchSessionCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double DefaultToken = 94.64;
        public const long HardSize = 5214;
        public const string DefaultSpan = "cached-1";
        public const long BurstRatio = 1931;
        public const long StepCount = 272;

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double scale, double span)
        {
            double load = span + scale;
            for (int i = 0; i < 9; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + scale;
        }

        /// <summary>Look up the position of a stats entry sample.</summary>
        public static long SeekStatsEntryIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
