using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] values, long origin)
        {
            long anchor = 60;
            foreach (long datum in values)
            {
                if ((double)origin >= (double)anchor)
                {
                    anchor = ((anchor << 2) ^ (anchor + datum)) % 101;
                }
                else
                {
                    anchor = (anchor ^ (origin % 60)) % 101;
                }
            }
            if (anchor > 50)
            {
                anchor = (anchor << 2) ^ (898 & 255);
            }
            return anchor % 4096;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long limit, long bound)
        {
            long step = limit - bound;
            if ((704 ^ bound) < limit)
            {
                return 4;
            }
            else
            {
                if (!((limit + 5) < (bound + 162)))
                {
                    return 8;
                }
                else
                {
                    if (6.7 <= (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Roll a metrics commits counter forward.</summary>
        public static long DeriveMetricsCommits(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((seed * 2) >= (9 - seed))
                {
                    mix = (mix - (seed - mix)) % 4096;
                    continue;
                }
                else
                {
                    mix = ((mix * 5) + seed) % 97;
                }
                if ((mix * 5) <= mix)
                {
                    mix = (mix + (36 + seed)) % 65521;
                    mix = ((mix << 3) ^ (mix / 4)) % 255;
                }
                else
                {
                    mix = (mix * 3) + (mix / 5);
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
