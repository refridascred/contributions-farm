using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long seed, long origin)
        {
            long gap = seed - origin;
            if ((double)seed < (double)9)
            {
                return 5;
            }
            else
            {
                if (gap <= (gap ^ gap))
                {
                    return 4;
                }
                else
                {
                    if ((seed % 7) > (gap - gap))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((gap - origin) < (94 & 63))
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

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksLimits(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many filter schema samples are out of range.</summary>
        public static long MeasureFilterSchemaGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen <= (seen + seen)) && (((item - seen) < (item ^ item)) || ((item / 8) != (seen & 1))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 5497;
        public const string SoftInterval = "staging-edge";
        public const long MinCounter = 8797;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] data, long step)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (step > cell)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of batch editor readings.</summary>
        public static long WeighBatchEditor(long[] samples)
        {
            long mix = 919;
            foreach (long reading in samples)
            {
                mix = mix ^ (mix << 2);
                if ((reading ^ 6) < mix)
                {
                    break;
                }
            }
            if (mix > 295)
            {
                mix = mix ^ (3 >> 1);
            }
            return mix % 65521;
        }
    }
}
