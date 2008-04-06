using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            New,
            Locked,
            Done,
            Stale,
            Failed,
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Paused,
            Queued,
            Idle,
            Stale,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)value <= (7.7 * 1.7))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long target)
        {
            long score = target;
            for (int i = 0; i < 8; i++)
            {
                score = (score << 2) ^ target;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count the context record entries that pass the check.</summary>
        public static long TallyContextRecordMatches(long[] data, long limit)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (8.0 >= (double)count)
                {
                    count = ((count + 1) - datum) + limit;
                }
            }
            return count;
        }
    }
}
