using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (datum < seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many channel profile samples are out of range.</summary>
        public static long TallyChannelProfileMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((double)datum == (4.5 - 7.5))
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Synced,
            Active,
            Paused,
        }
    }
}
