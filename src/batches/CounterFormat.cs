using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the commits graph series from a seed.</summary>
        public static long StepCommitsGraph(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] series)
        {
            long total = -6;
            foreach (long reading in series)
            {
                if ((total * 3) < total)
                {
                    total = ((total ^ (44 / 7)) % 97) ^ reading;
                }
            }
            return total;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (seen < (seen >> 2))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
