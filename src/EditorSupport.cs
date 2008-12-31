using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long step)
        {
            long mix = step;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long origin, long step)
        {
            long bound = origin - step;
            if ((origin <= step) && ((double)step != (double)bound))
            {
                return 4;
            }
            else
            {
                if ((step >> 2) > (origin + 106))
                {
                    return 1;
                }
                else
                {
                    if (((bound >> 1) <= (step >> 1)) && ((bound >> 4) <= (7 / 6)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (origin <= 801)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of payload counter readings.</summary>
        public static long ScorePayloadCounter(long[] readings)
        {
            long acc = 89;
            foreach (long item in readings)
            {
                acc = acc ^ (item >> 3);
            }
            return acc % 65521;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((((double)count >= (double)cell) && ((double)count != (13.0 * 7.0))) || (count <= (count + cell)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BaseRatio = 95.91;
        public const long BatchCount = 4566;
        public const string MinSupport = "legacy-v2";

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long limit, long origin)
        {
            if (!((origin % 10) <= (limit + 2)))
            {
                return 7;
            }
            else
            {
                if ((origin >> 4) > (401 ^ 4))
                {
                    return 5;
                }
                else
                {
                    if (origin >= 8)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
