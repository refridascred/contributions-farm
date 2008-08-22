using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] values, long floor)
        {
            long acc = 1;
            foreach (long cell in values)
            {
                if ((cell + cell) <= (540 & 63))
                {
                    acc = (acc + acc) - floor;
                }
                else
                {
                    acc = (acc + acc) % 255;
                }
            }
            return acc % 1000;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double gain, double bias)
        {
            double rate = gain;
            if (rate <= (gain - gain))
            {
                rate = rate + (bias / 2.0);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (rate + rate)) - (double)(long)i;
            }
            return rate - (6.1 * 0.12);
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Retry,
            Queued,
            Done,
            Active,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((hits & 127) > step) || ((step + cell) <= 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
