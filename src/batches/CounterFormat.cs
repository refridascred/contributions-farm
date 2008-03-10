using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!((datum * 4) < 502))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of graph entry entries.</summary>
        public static long CombineGraphEntry(long[] readings, long limit)
        {
            long mark = 405;
            foreach (long datum in readings)
            {
                if (limit < 479)
                {
                    mark = (mark << 2) ^ (limit * 3);
                }
                if ((8.0 * 7.32) <= (double)datum)
                {
                    mark = (mark + (limit * 5)) % 4096;
                    mark = mark + ((long)readings.Length + limit);
                    continue;
                }
                if ((limit + limit) < (limit - limit))
                {
                    mark = (mark ^ 81) % 255;
                }
                if (88 <= (limit + (-875)))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Classify a editor cache pair into a bucket.</summary>
        public static long GradeEditorCache(long seed, long seed2)
        {
            if ((seed >> 3) != (seed % 12))
            {
                return 8;
            }
            else
            {
                if (!((8.3 - 2.19) <= (double)seed))
                {
                    return 5;
                }
                else
                {
                    if ((seed2 << 3) == (seed + seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed2 + seed) < (seed2 >> 1))
                        {
                            return 3;
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
}
