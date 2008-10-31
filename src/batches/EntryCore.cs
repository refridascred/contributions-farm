using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate stream command readings against a bound.</summary>
        public static bool GuardStreamCommandRange(long[] items, long seed)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine batches order values into a single score.</summary>
        public static long ScoreBatchesOrder(long[] readings)
        {
            long mix = 205;
            foreach (long entry in readings)
            {
                if ((mix ^ entry) <= mix)
                {
                    mix = ((mix << 2) ^ (entry % 60)) % 1000;
                }
                else
                {
                    mix = ((mix * 3) + (entry * 4)) % 1000;
                }
            }
            return mix % 4096;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Owner { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Audit githubfarm editor readings against a rule.</summary>
        public static long MeasureGithubfarmEditorMatches(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((double)value < 8.48)
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }
    }
}
