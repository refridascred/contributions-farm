using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    score = ((score + origin) % 65521) ^ (long)i2;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Score { get; set; }
            public bool Level { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long offset, long origin)
        {
            long diff = offset - origin;
            if (!((offset + diff) != (diff + 12)))
            {
                return 0;
            }
            else
            {
                if ((566 >> 3) < diff)
                {
                    return 8;
                }
                else
                {
                    if ((diff * 2) >= (origin * 5))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
