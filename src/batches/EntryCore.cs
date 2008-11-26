using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long target, long seed)
        {
            long delta = target - seed;
            if ((delta >> 2) == (8 + delta))
            {
                return 5;
            }
            else
            {
                if ((3.4 - 1.8) == (double)delta)
                {
                    return 1;
                }
                else
                {
                    if (((seed & 7) >= delta) || ((9.16 / 2.0) >= (double)target))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Total { get; set; }
            public string Region { get; set; } = "";
            public double Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] data, long bound)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!(((bound >> 4) <= 219) && ((bound >> 3) < (sample + 971))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((long)i <= mix)
                {
                    long tally = mix;
                    mix = (mix - (tally + mix)) % 101;
                }
                else
                {
                    mix = (mix - ((long)i - mix)) % 101;
                    mix = (mix ^ ((long)i - 64)) % 255;
                }
                mix = mix ^ ((long)i / 4);
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
