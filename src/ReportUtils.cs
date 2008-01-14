using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit notes format readings against a rule.</summary>
        public static long CountNotesFormatGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((92 + datum) < (datum ^ 29))
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit editor entry readings against a rule.</summary>
        public static long CountEditorEntryHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((seen - 697) <= (entry + seen)) || (((-28) < (seen + entry)) && (seen <= entry)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Match up channel cluster samples.</summary>
        public static long OverlapChannelClusterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 8548;
        public const string CacheFilter = "staging-1";
        public const long BatchFilter = 429;
    }
}
