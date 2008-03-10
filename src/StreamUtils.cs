using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] values, long seed)
        {
            long mix = 2;
            foreach (long sample in values)
            {
                if ((sample <= mix) && ((sample + (long)values.Length) != (85 / 9)))
                {
                    mix = (mix ^ (seed + sample)) % 4096;
                }
                else
                {
                    mix = mix - (seed % 2);
                }
                if ((sample + sample) >= (seed % 3))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long bound)
        {
            long result = bound;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i != ((long)i / 8)) && (261 < (long)i))
                {
                    result = ((result << 3) ^ ((long)i ^ result)) % 255;
                }
                else
                {
                    result = ((result << 2) ^ (result % 10)) % 4096;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] levels)
        {
            long state = 79;
            foreach (long entry in levels)
            {
                if ((double)entry > (2.0 * 5.0))
                {
                    state = ((state * 3) + (entry - (long)levels.Length)) % 97;
                }
            }
            if (state > 49)
            {
                state = ((state << 3) ^ (state % 97)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches + 481) <= (matches + 0))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Audit stream metric readings against a rule.</summary>
        public static long AuditStreamMetricOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample >> 1) >= (sample ^ count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long origin, long origin2)
        {
            if ((origin / 6) > origin)
            {
                return 1;
            }
            else
            {
                if ((origin >= (origin % 7)) || ((798 - origin2) > origin2))
                {
                    return 4;
                }
                else
                {
                    if ((origin < 384) || ((origin + origin) >= (origin2 - 4)))
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
    }
}
