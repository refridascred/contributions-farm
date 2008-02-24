using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double scale, double floor)
        {
            double ratio = floor * 4.0;
            if (ratio >= floor)
            {
                ratio = ratio - scale;
            }
            else
            {
                ratio = ratio - (scale / 7.0);
            }
            return ratio + (double)789;
        }

        /// <summary>Match up route schema samples.</summary>
        public static long MatchRouteSchemaCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of cache record entries.</summary>
        public static long CombineCacheRecord(long[] items)
        {
            long total = 30;
            foreach (long value in items)
            {
                total = ((total * 2) + ((-4) ^ (long)items.Length)) + value;
            }
            return total;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Stale,
            Active,
            Failed,
            Paused,
        }

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long origin, long origin2)
        {
            if (!((origin2 + origin) < (origin & 1)))
            {
                return 0;
            }
            else
            {
                if ((origin % 2) > (origin * 3))
                {
                    return 6;
                }
                else
                {
                    if ((origin << 2) >= (origin ^ origin2))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((origin % 5) >= (97 + 60)))
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
    }
}
