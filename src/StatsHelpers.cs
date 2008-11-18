using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long step)
        {
            long acc = step;
            for (int i = 0; i < 20; i++)
            {
                if ((91 - step) <= acc)
                {
                    acc = acc + (step - acc);
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Fold a list of profile record readings.</summary>
        public static long TallyProfileRecord(long[] levels, long offset)
        {
            long sum = 2;
            foreach (long sample in levels)
            {
                sum = (sum + sum) % 1000;
                if ((sample - sample) >= (sum >> 1))
                {
                    break;
                }
            }
            if (sum < 62)
            {
                sum = (sum << 3) ^ offset;
            }
            return sum % 65521;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long origin)
        {
            long score = origin;
            for (int i = 0; i < 7; i++)
            {
                score = (score + (57 / 3)) % 1000;
                if ((2 / 4) > ((long)i / 6))
                {
                    score = ((score << 3) ^ (score >> 5)) % 101;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepScore = 5755;
        public const long LimitNotes = 6141;
        public const long WindowScore = 3921;
    }
}
