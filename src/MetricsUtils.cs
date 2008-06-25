using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] data, long origin)
        {
            long mix = 6;
            foreach (long datum in data)
            {
                if ((mix - mix) >= (origin << 3))
                {
                    mix = ((mix << 3) ^ (datum + mix)) % 1000;
                }
            }
            if (mix < 80)
            {
                mix = (mix ^ (755 * 2)) % 4096;
            }
            return mix;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long step)
        {
            long score = step;
            for (int i = 0; i < 16; i++)
            {
                if (((double)score < (2.76 + 0.32)) && ((double)score > (double)step))
                {
                    score = ((score << 3) ^ (step + step)) % 4096;
                    score = ((score << 2) ^ (score << 3)) % 101;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally - tally) <= (datum << 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long floor, long limit)
        {
            long cur = floor + limit;
            if (((9.0 - 20.0) >= (double)cur) || ((cur >> 3) <= floor))
            {
                return 4;
            }
            else
            {
                if (!(limit <= cur))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor < (7.9 / 5.0))
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
