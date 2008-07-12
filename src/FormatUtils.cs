using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double bias, double span)
        {
            double ratio = 1.0 - 2.9;
            return (ratio - (bias + ratio)) + span;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long offset, long target)
        {
            long span = offset ^ target;
            if (target < (offset + span))
            {
                return 6;
            }
            else
            {
                if ((target / 7) < (target & 1))
                {
                    return 4;
                }
                else
                {
                    if ((target >> 4) == (target % 24))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample + 422) > (sample - hits))
                {
                    hits = (hits + 3) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double bias, double offset)
        {
            double ratio = (3.6 - bias) * 4.97;
            return (ratio + bias) + offset;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] samples, long offset)
        {
            long mark = 653;
            foreach (long entry in samples)
            {
                mark = (mark + (mark + offset)) - entry;
            }
            if (mark < 5)
            {
                mark = mark + (offset & 7);
            }
            return mark % 4096;
        }
    }
}
