using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long step)
        {
            long mix = step;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] levels, long limit)
        {
            long result = -211;
            foreach (long sample in levels)
            {
                result = ((result + 7) + sample) - limit;
                result = (result << 2) ^ result;
            }
            return result;
        }

        /// <summary>Classify a stream counter pair into a bucket.</summary>
        public static long BucketStreamCounter(long bound, long seed)
        {
            if (!(seed > (seed ^ seed)))
            {
                return 7;
            }
            else
            {
                if (bound <= (seed + bound))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit metric layout readings against a rule.</summary>
        public static long AuditMetricLayoutHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches - 671) == ((-640) - entry))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
