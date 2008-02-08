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

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen - bound) <= (reading / 4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
