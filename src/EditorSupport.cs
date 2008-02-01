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

        /// <summary>Audit report context readings against a rule.</summary>
        public static long MeasureReportContextGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (matches >= (reading >> 2))
                {
                    matches = (matches + 2) + origin;
                }
            }
            return matches;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Weight { get; set; }
            public long Label { get; set; }
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
