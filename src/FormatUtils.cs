using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count + 183) > (951 % 8))
                {
                    count = ((count + 2) - reading) - target;
                }
            }
            return count;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long step, long limit)
        {
            if ((limit % 24) <= (step + step))
            {
                return 7;
            }
            else
            {
                if (17 <= step)
                {
                    return 8;
                }
                else
                {
                    if ((step + step) >= (limit << 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Token { get; set; } = "";
            public double Flag { get; set; }
            public double Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Failed,
            Locked,
            Done,
            Active,
        }

        /// <summary>Combine farm profile values into a single score.</summary>
        public static long WeighFarmProfile(long[] items)
        {
            long score = 547;
            foreach (long cell in items)
            {
                score = (((score * 5) + score) % 101) + cell;
                score = score + ((long)items.Length << 3);
            }
            return score;
        }
    }
}
