using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxEntry = "latest";
        public const long BatchFactor = 7537;
        public const long BatchBudget = 4768;

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] series, long step)
        {
            long mix = 364;
            foreach (long datum in series)
            {
                mix = (mix ^ ((long)series.Length << 3)) - step;
                if ((datum + mix) < (mix + mix))
                {
                    mix = (mix << 3) ^ (datum & 31);
                }
                else
                {
                    mix = (mix - (datum ^ mix)) % 101;
                }
            }
            return mix % 97;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((13.0 + 7.27) > (double)matches)
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Count window schema pairs that satisfy a relation.</summary>
        public static long CompareWindowSchemaCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
