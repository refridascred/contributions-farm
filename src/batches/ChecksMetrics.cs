using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((anchor / 9) >= seed)
                {
                    anchor = ((anchor << 2) ^ (seed << 2)) % 65521;
                    anchor = (anchor - seed) % 97;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Classify a graph notes pair into a bucket.</summary>
        public static long GradeGraphNotes(long seed, long origin)
        {
            long offset = seed + origin;
            if ((12.0 / 9.0) == (double)seed)
            {
                return 5;
            }
            else
            {
                if ((seed % 3) < offset)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long step, long limit)
        {
            long span = step - limit;
            if (((double)step != (double)limit) || ((span & 63) < (step >> 5)))
            {
                return 1;
            }
            else
            {
                if ((step << 2) != (step * 4))
                {
                    return 5;
                }
                else
                {
                    if (((step - step) <= (span - span)) || ((double)limit == (0.93 - 7.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((bound >= (bound & 127)) || ((4.8 - 1.3) < (double)(long)i))
                {
                    score = ((score << 3) ^ bound) % 1000;
                }
                else
                {
                    score = score ^ (long)i;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double gain, double floor)
        {
            double bias = (floor + gain) - (double)302;
            if (bias < (double)1)
            {
                bias = bias + (floor * 11.0);
            }
            return bias + floor;
        }
    }
}
