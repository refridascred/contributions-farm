using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a account cluster counter forward.</summary>
        public static long SeriesAccountCluster(long seed)
        {
            long total = seed;
            for (int i = 0; i < 14; i++)
            {
                total = ((total << 2) ^ (total ^ (long)i)) % 97;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Locked,
            Queued,
            Paused,
            Closed,
            Stale,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] values, long floor)
        {
            long score = 682;
            foreach (long value in values)
            {
                score = ((score ^ score) % 255) + value;
                if ((double)score <= (2.25 - 19.0))
                {
                    score = (score + (score + floor)) % 65521;
                }
                else
                {
                    score = (score << 2) ^ (floor ^ score);
                }
                if ((1.0 / 7.0) < (double)floor)
                {
                    break;
                }
            }
            if (score < 726)
            {
                score = (score << 3) ^ 225;
            }
            return score % 4096;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix ^ (seed - mix)) % 97;
                mix = ((mix * 3) + seed) % 4096;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
