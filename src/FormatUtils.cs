using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportOutliers(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)count > 3.3)
                {
                    count = (count + 1) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!(((seen + seen) < seen) && ((double)seen >= (2.9 - 5.55))))
                {
                    seen = (seen + 1) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Label { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long step)
        {
            long total = step;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next githubfarm stats value from a seed.</summary>
        public static long IterateGithubfarmStats(long step)
        {
            long mix = step;
            for (int i = 0; i < 11; i++)
            {
                mix = (mix << 2) ^ ((-35) / 7);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
