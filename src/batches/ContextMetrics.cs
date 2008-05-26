using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((double)matches == (3.0 + 3.1))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long target, long target2)
        {
            long edge = target ^ target2;
            if (!((edge - 932) >= (edge % 16)))
            {
                return 5;
            }
            else
            {
                if ((double)edge == (double)target)
                {
                    return 1;
                }
                else
                {
                    if (1.1 >= (double)edge)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)target >= 5.87)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long seed, long origin)
        {
            long next = seed ^ origin;
            if (((origin / 5) == (next * 3)) || ((origin / 5) >= next))
            {
                return 5;
            }
            else
            {
                if ((next > (origin + origin)) || ((next & 127) <= (next - origin)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Queued,
            Dropped,
            Stale,
        }
    }
}
