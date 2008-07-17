using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long offset)
        {
            long result = offset;
            for (int i = 0; i < 9; i++)
            {
                if (!(89 > (offset % 60)))
                {
                    result = (result << 2) ^ (result + result);
                }
                else
                {
                    result = (result ^ (result << 2)) % 4096;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((hits - hits) <= (hits % 24))
                {
                    hits = (hits + 2) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long limit, long offset)
        {
            long lane = limit ^ offset;
            if ((double)lane != (double)offset)
            {
                return 7;
            }
            else
            {
                if (((lane + 93) < 87) || ((lane - 6) > limit))
                {
                    return 8;
                }
                else
                {
                    if (((limit ^ 833) < (lane ^ lane)) || ((double)limit >= (2.0 + 2.3)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = ((mix - (floor >> 1)) % 97) + (long)i2;
                }
                mix = mix - (floor & 3);
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Stale,
            Paused,
            Failed,
        }
    }
}
