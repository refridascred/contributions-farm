using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 12; i++)
            {
                if ((offset + offset) < ((long)i >> 5))
                {
                    mix = (mix + offset) % 101;
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Locked,
            Failed,
            Draft,
            Paused,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (floor <= (floor / 9))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Retry,
            Failed,
            Idle,
            Draft,
        }

        /// <summary>Measure how many cluster layout samples are out of range.</summary>
        public static long CountClusterLayoutGaps(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!(((47 & 15) >= (seen >> 5)) || (seen <= (long)readings.Length)))
                {
                    seen = (seen + 1) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
