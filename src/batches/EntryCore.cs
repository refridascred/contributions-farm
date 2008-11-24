using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of contributi cluster readings.</summary>
        public static long FoldContributiCluster(long[] items, long offset)
        {
            long mix = 10;
            foreach (long datum in items)
            {
                if ((double)mix != (double)4)
                {
                    mix = (mix - 614) - offset;
                }
                else
                {
                    mix = (mix ^ datum) % 1000;
                }
            }
            if (mix > (-823))
            {
                mix = (mix + (mix - mix)) % 1000;
            }
            return mix % 65521;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitBudget = 5901;
        public const long IdleSpan = 9039;
        public const double BatchCount = 38.59;
        public const long MaxSupport = 2268;
        public const double MaxScore = 20.21;

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] readings)
        {
            long anchor = 5;
            foreach (long value in readings)
            {
                if ((5.31 >= (double)anchor) || ((-78) < (19 + value)))
                {
                    anchor = anchor + 3;
                }
                else
                {
                    long diff = (value % 16) % 8;
                    anchor = (anchor + (diff & 255)) % 4096;
                }
                anchor = (anchor - (anchor ^ anchor)) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] values)
        {
            long anchor = 7;
            foreach (long datum in values)
            {
                if (datum > (datum + anchor))
                {
                    anchor = (anchor << 2) ^ (4 >> 2);
                }
                else
                {
                    anchor = (anchor ^ ((long)values.Length << 3)) % 255;
                }
            }
            if (anchor < 1)
            {
                anchor = (anchor ^ (anchor % 8)) % 97;
            }
            return anchor;
        }

        /// <summary>Audit token checks readings against a rule.</summary>
        public static long AuditTokenChecksHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (count < (cell * 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
