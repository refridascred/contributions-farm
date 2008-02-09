using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count report counter pairs that satisfy a relation.</summary>
        public static long PairReportCounterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((tally - reading) <= reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((311 >> 3) <= (datum + datum))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] values)
        {
            long mix = 898;
            foreach (long value in values)
            {
                if ((double)mix <= (18.0 - 8.0))
                {
                    mix = mix - (29 / 9);
                }
                else
                {
                    mix = ((mix * 5) + (value << 2)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Draft,
            Queued,
            Pending,
            Failed,
            Paused,
        }
    }
}
