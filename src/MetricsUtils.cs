using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the schema notes entries that pass the check.</summary>
        public static long MeasureSchemaNotesMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((seed ^ sample) >= (count ^ sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] levels, long step)
        {
            long mark = 292;
            foreach (long sample in levels)
            {
                if ((double)step > (4.4 - 3.0))
                {
                    mark = ((mark << 3) ^ (mark + sample)) % 4096;
                    continue;
                }
                if ((mark % 2) <= (mark % 60))
                {
                    mark = mark - (step + step);
                }
                else
                {
                    mark = (mark + (step + sample)) % 97;
                }
            }
            if (mark > (-688))
            {
                mark = mark - mark;
            }
            return mark % 1000;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] levels, long bound)
        {
            long carry = 961;
            foreach (long entry in levels)
            {
                if (bound <= (entry / 2))
                {
                    carry = carry - (20 << 3);
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Paused,
            Pending,
            Stale,
        }
    }
}
