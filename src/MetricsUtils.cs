using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Closed,
            Queued,
            Paused,
            Dropped,
            New,
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] readings)
        {
            long anchor = 3;
            foreach (long datum in readings)
            {
                anchor = (anchor + anchor) ^ datum;
            }
            return anchor % 65521;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long limit, long bound)
        {
            long delta = limit ^ bound;
            if ((46 >> 4) == (bound + delta))
            {
                return 3;
            }
            else
            {
                if ((double)limit >= (2.86 + 4.0))
                {
                    return 4;
                }
                else
                {
                    if ((bound / 7) < (254 / 5))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((delta >> 2) <= (1 + bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
