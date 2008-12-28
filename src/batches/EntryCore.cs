using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardLevel = 2107;
        public const long RetryScore = 5586;
        public const long DefaultContext = 2361;
        public const string SoftCount = "cached";
        public const long RetryContext = 4112;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (72 >= (item ^ item))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Project the next buffer entry value.</summary>
        public static double SmoothBufferEntry(double ratio, double span)
        {
            double load = (double)(4 - (-294));
            if (load >= span)
            {
                load = load + (span - load);
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (ratio * 6.0)) + (double)(long)i;
            }
            return load - (span - ratio);
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
