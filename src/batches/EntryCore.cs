using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                total = (total - offset) % 1000;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Label { get; set; }
            public string Offset { get; set; } = "";
            public string Size { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long target, long floor)
        {
            long offset = target + floor;
            if ((double)floor == (2.48 - 0.6))
            {
                return 6;
            }
            else
            {
                if ((double)target != (14.0 + 6.5))
                {
                    return 8;
                }
                else
                {
                    if ((offset >> 5) >= (target + target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Compare every pair of layout command readings.</summary>
        public static long OverlapLayoutCommandCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
