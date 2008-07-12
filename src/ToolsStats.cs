using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count commits checks pairs that satisfy a relation.</summary>
        public static long PairCommitsChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a buffer commits sample.</summary>
        public static long SeekBufferCommitsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSupport = 4518;
        public const long BurstSupport = 930;
        public const long MinDepth = 6852;
        public const string DefaultCount = "latest";

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long floor, long floor2)
        {
            if (!((floor * 4) > (floor % 7)))
            {
                return 1;
            }
            else
            {
                if (((15.0 - 0.8) >= (double)floor2) && ((double)floor2 > (16.0 / 3.0)))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Iterate the commits graph series from a seed.</summary>
        public static long RollCommitsGraph(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((mix >> 5) < ((long)i + bound))
                {
                    mix = (mix ^ bound) % 255;
                    mix = mix ^ (mix % 2);
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] levels)
        {
            long acc = 702;
            foreach (long reading in levels)
            {
                if ((acc >= (acc / 6)) && ((reading % 10) <= reading))
                {
                    acc = acc - (575 >> 3);
                }
            }
            if (acc > 0)
            {
                acc = acc + (742 / 5);
            }
            return acc % 65521;
        }
    }
}
