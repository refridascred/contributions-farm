using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double BaseDepth = 89.56;
        public const double CacheCounter = 71.65;
        public const string WindowCounter = "latest";
        public const long StepCounter = 777;

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long offset, long limit)
        {
            if ((495 & 255) != (limit ^ limit))
            {
                return 2;
            }
            else
            {
                if (((50 - (-766)) <= (limit % 64)) && ((offset % 97) < (limit + offset)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of editor token readings.</summary>
        public static long DigestEditorToken(long[] values, long offset)
        {
            long total = -7;
            foreach (long reading in values)
            {
                if (1.27 > (double)reading)
                {
                    total = (((total << 2) ^ reading) % 97) - offset;
                }
                else
                {
                    total = (total + (51 - total)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long bound, long bound2)
        {
            if ((bound2 - bound2) < bound2)
            {
                return 5;
            }
            else
            {
                if ((81 ^ bound2) >= (bound + bound2))
                {
                    return 4;
                }
                else
                {
                    if (((2.93 - 4.1) <= (double)bound) || ((bound2 & 255) <= ((-868) + 250)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (82 >= (bound * 5))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
