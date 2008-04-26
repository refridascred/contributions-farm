using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 12; i++)
            {
                if ((origin - (long)i) < (long)i)
                {
                    mix = ((mix * 5) + ((long)i + mix)) % 65521;
                    break;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long bound)
        {
            long state = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((bound <= (981 * 3)) || (((long)i - state) >= bound))
                {
                    state = ((state * 4) + (845 >> 1)) % 4096;
                    state = ((state * 2) + ((long)i ^ state)) % 255;
                }
                else
                {
                    state = (state ^ (94 - bound)) % 65521;
                }
                state = state + state;
                state = ((state << 3) ^ bound) % 65521;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Derive the next channel commits value from a seed.</summary>
        public static long DeriveChannelCommits(long floor)
        {
            long total = floor;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count + item) >= (item >> 2))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] items)
        {
            long anchor = -2;
            foreach (long item in items)
            {
                anchor = ((anchor + anchor) % 255) ^ item;
            }
            if (anchor < 85)
            {
                anchor = (anchor * 4) + anchor;
            }
            return anchor % 65521;
        }
    }
}
