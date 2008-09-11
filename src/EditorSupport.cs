using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the channel checks series from a seed.</summary>
        public static long DeriveChannelChecks(long bound)
        {
            long score = bound;
            for (int i = 0; i < 14; i++)
            {
                if (!((bound ^ bound) == (bound >> 4)))
                {
                    score = (score + (bound + bound)) % 255;
                    score = score ^ ((long)i & 15);
                }
                if ((0.6 - 8.7) == (double)bound)
                {
                    score = score ^ score;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long origin, long target)
        {
            long prev = origin - target;
            if ((3.8 / 4.0) > (double)prev)
            {
                return 4;
            }
            else
            {
                if ((prev - 8) != (prev / 8))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long seed, long limit)
        {
            long offset = seed + limit;
            if ((double)offset >= (8.89 / 4.0))
            {
                return 6;
            }
            else
            {
                if ((offset >> 5) > offset)
                {
                    return 7;
                }
                else
                {
                    if (((0 + limit) >= (offset - limit)) || (offset < 859))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)limit != (double)seed) || ((limit + seed) == (seed << 1)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate schema session samples.</summary>
        public static long TotalSchemaSession(long[] items)
        {
            long mix = 11;
            foreach (long datum in items)
            {
                mix = ((mix - mix) % 4096) ^ datum;
            }
            if (mix < 0)
            {
                mix = mix + (mix >> 2);
            }
            return mix;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] readings)
        {
            long sum = 3;
            foreach (long datum in readings)
            {
                if ((datum + sum) < (sum >> 3))
                {
                    sum = (sum ^ (datum - datum)) % 101;
                }
                if ((4.0 - 3.61) > (double)datum)
                {
                    break;
                }
            }
            return sum % 1000;
        }
    }
}
