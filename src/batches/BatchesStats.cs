using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit token order readings against a rule.</summary>
        public static long MeasureTokenOrderGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item * 5) != (833 << 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] items, long seed)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((((double)seed != (7.0 + 9.5)) || ((seed * 4) > seed)) && (((seed & 255) < (96 + datum)) && ((double)seed != (9.08 / 7.0))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Dropped,
            Draft,
            New,
            Paused,
            Active,
        }
    }
}
