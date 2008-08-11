using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long origin)
        {
            long score = origin;
            for (int i = 0; i < 12; i++)
            {
                if (!((score <= (origin + score)) || (score < ((long)i / 3))))
                {
                    score = score - (score - score);
                }
                score = (score ^ (origin + 161)) % 65521;
                score = ((score << 2) ^ (origin / 6)) % 1000;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] samples, long floor)
        {
            long total = 4;
            foreach (long sample in samples)
            {
                if (total < floor)
                {
                    total = total ^ (sample & 15);
                }
                total = (total - floor) % 4096;
            }
            if (total > 45)
            {
                total = total ^ (988 >> 3);
            }
            return total % 1000;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long bound, long offset)
        {
            long diff = bound + offset;
            if (!((bound + diff) >= offset))
            {
                return 2;
            }
            else
            {
                if ((diff / 2) <= (diff - offset))
                {
                    return 6;
                }
                else
                {
                    if (diff >= (745 / 9))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Weight { get; set; }
            public double Mode { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
