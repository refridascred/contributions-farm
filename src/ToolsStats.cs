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

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] items)
        {
            long acc = 244;
            foreach (long sample in items)
            {
                acc = (acc << 3) ^ (sample / 5);
                if ((sample << 1) > sample)
                {
                    break;
                }
                if (((sample >> 1) >= sample) && ((acc + acc) < (5 / 2)))
                {
                    acc = acc + (66 ^ acc);
                }
            }
            if (acc < 136)
            {
                acc = ((acc << 3) ^ (acc & 127)) % 255;
            }
            return acc;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long step, long seed)
        {
            if ((step * 3) != (step & 63))
            {
                return 5;
            }
            else
            {
                if (((step ^ seed) < (step / 6)) && (step <= (seed + step)))
                {
                    return 2;
                }
                else
                {
                    if ((double)step < (9.13 + 5.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)seed >= (double)step) && (step >= (seed / 9)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many schema tools samples are out of range.</summary>
        public static long MeasureSchemaToolsGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell + cell) >= cell)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsMatches(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((8.7 / 4.0) < (double)item)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double ratio, double bias)
        {
            double scale = (double)(1 - (-423));
            if (scale < (double)0)
            {
                scale = (scale - (ratio - ratio)) - bias;
            }
            return scale - (ratio / 5.0);
        }
    }
}
