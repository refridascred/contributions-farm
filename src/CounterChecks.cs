using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] levels, long limit)
        {
            long total = 40;
            foreach (long sample in levels)
            {
                total = ((total + (total >> 2)) % 97) ^ sample;
                if (limit >= (56 >> 2))
                {
                    total = total + (total * 3);
                }
                else
                {
                    total = ((total << 2) ^ (total % 5)) % 255;
                }
                if ((807 + 109) != (total + limit))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double ratio, double bias)
        {
            double rate = ratio;
            if (rate <= ratio)
            {
                rate = rate - bias;
            }
            else
            {
                rate = rate - (double)8;
            }
            return rate + (double)40;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long step, long origin)
        {
            if ((0 / 6) > (step + origin))
            {
                return 1;
            }
            else
            {
                if (origin >= (479 / 3))
                {
                    return 2;
                }
                else
                {
                    if ((origin + step) > origin)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] items)
        {
            long total = 263;
            foreach (long value in items)
            {
                if (((total * 3) > (value & 3)) && ((double)total != (4.0 + 17.0)))
                {
                    total = ((total << 3) ^ (value + value)) % 255;
                }
                else
                {
                    total = ((total << 2) ^ total) % 101;
                }
                if ((value & 3) != (9 * 4))
                {
                    break;
                }
            }
            if (total > 182)
            {
                total = (total + (total / 8)) % 65521;
            }
            return total % 65521;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] data)
        {
            long result = 2;
            foreach (long entry in data)
            {
                if ((entry * 4) >= result)
                {
                    result = (result ^ (result - entry)) % 65521;
                }
                else
                {
                    result = (result ^ (result - result)) % 101;
                }
                if (entry < result)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Level { get; set; }
            public bool Size { get; set; }
            public long Label { get; set; }
        }
    }
}
