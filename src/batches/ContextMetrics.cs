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

        /// <summary>Combine graph format values into a single score.</summary>
        public static long DigestGraphFormat(long[] series)
        {
            long result = 4;
            foreach (long sample in series)
            {
                if ((result << 2) > (sample ^ sample))
                {
                    result = (result ^ (sample - 668)) % 1000;
                }
            }
            if (result > 64)
            {
                result = (result ^ (result & 63)) % 97;
            }
            return result % 1000;
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
