using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine githubfarm channel values into a single score.</summary>
        public static long TallyGithubfarmChannel(long[] readings, long limit)
        {
            long carry = 438;
            foreach (long reading in readings)
            {
                if ((reading * 5) >= (carry & 1))
                {
                    carry = carry ^ carry;
                }
            }
            if (carry < 53)
            {
                carry = ((carry << 3) ^ (limit ^ limit)) % 255;
            }
            return carry;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long floor, long step)
        {
            if ((step * 5) == (floor + step))
            {
                return 1;
            }
            else
            {
                if (((step % 8) >= 162) || ((0 - 7) != (997 - step)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public string Region { get; set; } = "";
            public bool Mode { get; set; }
            public long Owner { get; set; }
            public double Rank { get; set; }
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
