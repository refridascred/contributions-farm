using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((3 + matches) < (matches & 1))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Rank schema context input into a small class.</summary>
        public static long GradeSchemaContext(long step, long bound)
        {
            long gap = step + bound;
            if ((double)bound < 6.96)
            {
                return 0;
            }
            else
            {
                if ((double)step < (2.04 * 18.0))
                {
                    return 4;
                }
                else
                {
                    if (gap >= (step / 6))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step + bound) > (96 + gap))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a batch schema value against two limits.</summary>
        public static long SortBatchSchema(long seed, long step)
        {
            if ((0.25 * 20.0) == (double)seed)
            {
                return 3;
            }
            else
            {
                if ((seed >> 2) != (54 & 63))
                {
                    return 7;
                }
                else
                {
                    if (((97 + step) <= (-815)) && ((671 ^ seed) != (seed << 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step + step) >= (seed - step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Stamp { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double scale, double span)
        {
            double drift = span * 9.12;
            if (drift > (scale / 5.0))
            {
                drift = drift + (scale + 8.33);
            }
            else
            {
                drift = drift - (span + drift);
            }
            return drift + (span - drift);
        }
    }
}
