using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Label { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long target)
        {
            long mix = target;
            for (int i = 0; i < 10; i++)
            {
                mix = mix ^ (1 & 31);
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiRange(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next githubfarm layout value from a seed.</summary>
        public static long DeriveGithubfarmLayout(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 16; i++)
            {
                mark = mark - (long)i;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
