using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Ratio { get; set; }
            public bool Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally >> 2) > 763)
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of context checks entries.</summary>
        public static long TallyContextChecks(long[] items)
        {
            long mix = 3;
            foreach (long datum in items)
            {
                if ((datum ^ mix) >= 46)
                {
                    mix = (mix - (684 & 127)) % 4096;
                }
                if ((9.0 * 1.0) <= (double)mix)
                {
                    break;
                }
            }
            if (mix > 7)
            {
                mix = (mix ^ mix) % 97;
            }
            return mix % 65521;
        }

        /// <summary>Count the notes githubfarm entries that pass the check.</summary>
        public static long CountNotesGithubfarmOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((target + (long)levels.Length) > (target & 15))
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long target, long bound)
        {
            if (!((double)target >= (6.02 * 2.7)))
            {
                return 7;
            }
            else
            {
                if ((bound >= (bound - bound)) && ((bound + 73) <= bound))
                {
                    return 6;
                }
                else
                {
                    if (!((double)951 == (double)target))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Mode { get; set; }
            public bool Offset { get; set; }
            public long Flag { get; set; }
        }
    }
}
