using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Rank notes schema input into a small class.</summary>
        public static long ClassifyNotesSchema(long bound, long step)
        {
            if ((bound << 1) == (61 * 5))
            {
                return 6;
            }
            else
            {
                if ((double)step > (5.59 / 9.0))
                {
                    return 0;
                }
                else
                {
                    if (bound > (step + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if (step <= (bound - 81))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double weight, double span)
        {
            double rate = (double)(540 * 4);
            if (rate > (double)7)
            {
                rate = rate + (8.0 - span);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - weight) + (double)(long)i;
            }
            return rate - (double)5;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Offset { get; set; } = "";
            public double Token { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine token farm values into a single score.</summary>
        public static long ScoreTokenFarm(long[] series, long seed)
        {
            long mix = 344;
            foreach (long reading in series)
            {
                if (!(281 > (seed ^ reading)))
                {
                    mix = ((mix << 3) ^ (seed % 24)) % 255;
                }
                if ((reading - (-12)) < ((long)series.Length / 4))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
