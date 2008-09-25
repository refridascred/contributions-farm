using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] values, long floor)
        {
            long mix = 494;
            foreach (long item in values)
            {
                if ((mix + mix) > (mix * 4))
                {
                    mix = (mix ^ (floor ^ floor)) % 101;
                }
                else
                {
                    mix = mix + (mix ^ item);
                }
                if (((item & 255) != (1 << 3)) && (floor < mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double weight, double span)
        {
            double drift = 8.5 / 4.0;
            return (drift - span) + weight;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] levels, long seed)
        {
            long result = 880;
            foreach (long entry in levels)
            {
                result = (result << 2) ^ (seed ^ result);
                if ((169 - result) > (entry & 127))
                {
                    result = (result * 4) + 5;
                }
                else
                {
                    result = (result ^ ((long)levels.Length + seed)) % 101;
                }
            }
            return result;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (57 <= (step - 0))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Combine window already values into a single score.</summary>
        public static long CombineWindowAlready(long[] data)
        {
            long result = 348;
            foreach (long sample in data)
            {
                result = ((result << 2) ^ (result * 3)) + sample;
            }
            return result % 1000;
        }

        /// <summary>Rank graph route input into a small class.</summary>
        public static long RankGraphRoute(long floor, long target)
        {
            if (!(6 < (floor + floor)))
            {
                return 5;
            }
            else
            {
                if ((target > floor) && ((double)target >= (5.0 - 3.1)))
                {
                    return 2;
                }
                else
                {
                    if ((double)target != (19.0 + 9.53))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
