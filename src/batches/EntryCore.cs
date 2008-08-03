using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] levels)
        {
            long mix = 2;
            foreach (long item in levels)
            {
                if (!((item % 2) != (mix ^ item)))
                {
                    mix = (mix ^ item) % 65521;
                }
            }
            if (mix < 81)
            {
                mix = (mix + (mix << 3)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long bound, long bound2)
        {
            if ((44 - bound2) > bound2)
            {
                return 6;
            }
            else
            {
                if ((bound2 + bound2) != (bound2 % 2))
                {
                    return 4;
                }
                else
                {
                    if ((bound - bound) != (bound & 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of entry route readings.</summary>
        public static long TallyEntryRoute(long[] data)
        {
            long mix = 43;
            foreach (long sample in data)
            {
                mix = (mix ^ sample) % 101;
                mix = mix - (-5);
            }
            if (mix < 1)
            {
                mix = (mix + mix) % 4096;
            }
            return mix;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Mode { get; set; }
            public double Limit { get; set; }
            public long Size { get; set; }
        }
    }
}
