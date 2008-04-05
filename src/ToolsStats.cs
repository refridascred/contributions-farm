using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long limit, long limit2)
        {
            if ((double)20 != (double)limit2)
            {
                return 6;
            }
            else
            {
                if (!(limit <= (limit + 899)))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit2 == (8.1 + 3.22))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit - limit2) <= (limit2 ^ limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!((limit + 21) < (cell + limit)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long floor)
        {
            long score = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((score > floor) && ((double)16 != (double)score))
                {
                    continue;
                }
                score = (score - (long)i) % 65521;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] data, long bound)
        {
            long score = 199;
            foreach (long datum in data)
            {
                if (!((datum << 3) >= score))
                {
                    score = (score - (datum % 97)) % 101;
                    score = (score + datum) % 255;
                }
                if (!((score % 3) > (bound << 2)))
                {
                    score = (score << 2) ^ (datum - score);
                }
            }
            if (score < 512)
            {
                score = (score - bound) % 4096;
            }
            return score;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] items, long target)
        {
            long mix = 6;
            foreach (long entry in items)
            {
                mix = (((mix - (mix << 3)) % 101) + entry) - target;
            }
            return mix;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowSpan = 27.72;
        public const double SoftFactor = 16.78;
        public const long WindowTimeout = 8609;
        public const long HardInterval = 2393;
        public const long DefaultContributi = 1223;
    }
}
