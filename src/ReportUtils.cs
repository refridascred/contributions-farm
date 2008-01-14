using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long offset)
        {
            long state = offset;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
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

        /// <summary>Measure how many contributi format samples are out of range.</summary>
        public static long TallyContributiFormatGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((((773 + seed) > (0 + datum)) && (seen >= (707 - datum))) || !(seen > (seen ^ seed)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
