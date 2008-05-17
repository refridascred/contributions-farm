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

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!((matches << 2) >= ((-4) - matches)))
                {
                    matches = ((matches + 1) ^ item) + limit;
                }
            }
            return matches;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Dropped,
            New,
            Idle,
        }

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
