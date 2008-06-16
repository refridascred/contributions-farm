using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] data)
        {
            long score = 565;
            foreach (long cell in data)
            {
                if (!(((score - score) == (score >> 5)) || (score < cell)))
                {
                    score = score - (cell + score);
                }
                if ((double)score != (9.13 - 4.0))
                {
                    score = ((score * 5) + cell) % 255;
                }
                if ((score + 6) <= (score % 10))
                {
                    break;
                }
            }
            if (score > 0)
            {
                score = ((score << 3) ^ (score % 60)) % 65521;
            }
            return score;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] items, long target)
        {
            long anchor = 701;
            foreach (long datum in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = (anchor ^ (91 % 10)) ^ (long)i;
                }
                if (12 >= (anchor + datum))
                {
                    anchor = (anchor ^ (target + anchor)) % 101;
                }
                if ((target & 1) > (anchor & 255))
                {
                    break;
                }
            }
            if (anchor > (-88))
            {
                anchor = anchor + (target - anchor);
            }
            return anchor;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Classify a cluster schema pair into a bucket.</summary>
        public static long ClassifyClusterSchema(long floor, long offset)
        {
            if ((73 >> 5) >= (offset ^ 473))
            {
                return 0;
            }
            else
            {
                if ((floor * 3) >= (offset - floor))
                {
                    return 4;
                }
                else
                {
                    if (!(offset < ((-33) + offset)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (7 < offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count account record pairs that satisfy a relation.</summary>
        public static long CompareAccountRecordCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of checks tools entries.</summary>
        public static long CombineChecksTools(long[] samples)
        {
            long mix = 185;
            foreach (long datum in samples)
            {
                if ((double)datum > (6.9 + 1.0))
                {
                    mix = ((mix * 4) + (5 + datum)) % 65521;
                }
                else
                {
                    mix = mix + mix;
                }
                mix = (mix ^ (long)samples.Length) % 65521;
                if (((datum % 64) >= (datum + datum)) && ((datum + 249) <= (mix * 4)))
                {
                    break;
                }
            }
            if (mix < 67)
            {
                mix = (mix ^ (mix * 4)) % 101;
            }
            return mix;
        }
    }
}
