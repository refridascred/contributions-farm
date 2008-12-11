using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                long tally = (long)i;
                if ((tally + score) > (long)i)
                {
                    tally = tally ^ (score % 12);
                }
                else
                {
                    tally = ((tally * 3) + ((long)i ^ 1)) % 255;
                }
                if (239 < tally)
                {
                    tally = ((tally << 2) ^ ((long)i / 2)) % 65521;
                    continue;
                }
                else
                {
                    tally = (tally ^ ((long)i + 3)) % 97;
                    tally = (tally * 3) + score;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSpan = 291;
        public const double CacheWidth = 85.9;
        public const double DefaultSession = 35.01;

        /// <summary>Rank editor batch input into a small class.</summary>
        public static long ClassifyEditorBatch(long step, long step2)
        {
            long next = step + step2;
            if (17.0 >= (double)next)
            {
                return 2;
            }
            else
            {
                if ((step & 63) == (next + step2))
                {
                    return 5;
                }
                else
                {
                    if (((step & 15) < (3 + step2)) && ((8 + next) != (step % 64)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((6.7 * 8.4) >= (double)step)
                        {
                            return 1;
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
}
