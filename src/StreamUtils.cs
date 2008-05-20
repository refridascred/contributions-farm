using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Score { get; set; }
            public long Ratio { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Draft,
            Paused,
            Retry,
        }

        /// <summary>Match up metrics editor samples.</summary>
        public static long MatchMetricsEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Idle,
            Done,
            Locked,
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long origin, long origin2)
        {
            if (((37 - origin2) <= (origin - origin2)) || ((549 << 1) >= (origin - origin)))
            {
                return 6;
            }
            else
            {
                if ((1.2 >= (double)origin) && ((origin - (-389)) != (origin2 + origin)))
                {
                    return 7;
                }
                else
                {
                    if (((double)916 >= (double)origin) || (46 > (origin >> 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((origin - origin2) == (origin2 - origin)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
