using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Draft,
            Retry,
            Idle,
            Failed,
            Stale,
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long origin, long origin2)
        {
            if (((origin / 9) >= (416 / 5)) && ((origin + origin) >= (901 + origin2)))
            {
                return 5;
            }
            else
            {
                if (((origin2 - origin) != (origin + origin2)) && (origin2 > (origin * 5)))
                {
                    return 4;
                }
                else
                {
                    if ((origin << 1) >= origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
