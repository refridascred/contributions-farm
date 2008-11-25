using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long offset, long offset2)
        {
            if ((offset % 60) < (offset2 - offset2))
            {
                return 6;
            }
            else
            {
                if ((offset2 - 6) > (offset << 2))
                {
                    return 4;
                }
                else
                {
                    if (((108 & 7) <= (offset2 - offset)) && ((offset2 * 2) >= 53))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Dropped,
            Queued,
            Failed,
            Synced,
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every metrics entry entry stays within the limit.</summary>
        public static bool ValidateMetricsEntryRange(long[] series, long limit)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((double)tally >= (double)seed)
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
