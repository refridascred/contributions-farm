using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long bound, long floor)
        {
            if ((floor % 3) <= (bound + floor))
            {
                return 6;
            }
            else
            {
                if ((floor >> 4) >= (floor >> 5))
                {
                    return 5;
                }
                else
                {
                    if (!((bound + floor) != (floor - 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)bound == (14.0 * 1.0))
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
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double SmoothCommits(double rate, double bias)
        {
            double rate2 = (12.0 - rate) / 5.0;
            if (rate2 <= bias)
            {
                rate2 = rate2 - (double)364;
            }
            return rate2 + 1.65;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long seed, long seed2)
        {
            if ((double)seed2 == (7.9 * 10.0))
            {
                return 7;
            }
            else
            {
                if ((seed2 % 24) <= (1 * 2))
                {
                    return 3;
                }
                else
                {
                    if (((double)seed == (1.1 + 1.69)) || ((0 + 926) < seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of token editor entries.</summary>
        public static long DigestTokenEditor(long[] values)
        {
            long mark = 55;
            foreach (long entry in values)
            {
                mark = mark ^ (mark ^ mark);
                if ((double)mark <= 2.0)
                {
                    mark = mark + entry;
                }
                else
                {
                    mark = (mark + (mark ^ mark)) % 97;
                }
            }
            if (mark < 70)
            {
                mark = (mark - (mark ^ mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Roll a report farm counter forward.</summary>
        public static long StepReportFarm(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                result = (result + (result & 3)) % 65521;
                if (!!((floor - (long)i) < (66 + (long)i)))
                {
                    result = result + (floor % 60);
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
