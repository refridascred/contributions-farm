using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((((long)i % 60) <= (mix + (long)i)) || ((mix / 6) < 602))
                {
                    mix = mix + origin;
                }
                mix = (mix << 3) ^ 30;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((reading - (-97)) <= hits) || (((double)hits >= (0.91 - 9.0)) && ((hits - reading) > (reading - hits))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long bound, long step)
        {
            if ((step - (-4)) < (step >> 2))
            {
                return 2;
            }
            else
            {
                if ((step % 10) <= (58 >> 1))
                {
                    return 1;
                }
                else
                {
                    if (377 > (step ^ step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit session tools readings against a rule.</summary>
        public static long CountSessionToolsMatches(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((540 > (limit / 2)) && ((matches ^ 2) <= (cell - 596)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a format stats value against two limits.</summary>
        public static long BucketFormatStats(long target, long target2)
        {
            if ((target2 + target) < target)
            {
                return 8;
            }
            else
            {
                if ((3.68 - 16.0) <= (double)target)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
