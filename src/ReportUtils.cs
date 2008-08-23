using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long limit)
        {
            long state = limit;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Active,
            Closed,
            Queued,
            Done,
            Pending,
        }

        /// <summary>Measure how many queue command samples are out of range.</summary>
        public static long MeasureQueueCommandGaps(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((datum + 343) < datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine command counter values into a single score.</summary>
        public static long WeighCommandCounter(long[] levels)
        {
            long acc = 61;
            foreach (long reading in levels)
            {
                acc = ((acc << 2) ^ 204) ^ reading;
            }
            if (acc < 55)
            {
                acc = acc ^ (acc & 31);
            }
            return acc;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long target)
        {
            long anchor = target;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
