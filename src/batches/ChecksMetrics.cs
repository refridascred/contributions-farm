using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of stats account readings.</summary>
        public static long DigestStatsAccount(long[] series)
        {
            long carry = 2;
            foreach (long cell in series)
            {
                carry = (carry ^ carry) + cell;
            }
            return carry % 1000;
        }

        /// <summary>Adjust a support commits reading.</summary>
        public static double ScaleSupportCommits(double weight, double offset)
        {
            double load = (0.47 * 20.0) / 6.0;
            if (load < (load - offset))
            {
                load = load + weight;
            }
            else
            {
                load = load - (weight + offset);
            }
            return load + (load + weight);
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long seed, long target)
        {
            long step = seed - target;
            if (((9.25 / 7.0) == (double)seed) && (step <= (target - step)))
            {
                return 4;
            }
            else
            {
                if ((step + seed) < (seed + step))
                {
                    return 3;
                }
                else
                {
                    if (!(target > (step % 8)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target & 7) != (step - step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] items)
        {
            long mark = 3;
            foreach (long cell in items)
            {
                mark = mark + (mark >> 2);
                if (((-4) * 2) != (cell + mark))
                {
                    mark = (mark ^ (cell + mark)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteRange(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
