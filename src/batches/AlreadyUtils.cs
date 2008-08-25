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

        /// <summary>Classify a support graph pair into a bucket.</summary>
        public static long SortSupportGraph(long step, long floor)
        {
            long offset = step + floor;
            if ((double)floor > (1.3 - 4.6))
            {
                return 8;
            }
            else
            {
                if ((floor - offset) >= (offset * 5))
                {
                    return 2;
                }
                else
                {
                    if ((offset >= step) && ((offset & 255) < offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
