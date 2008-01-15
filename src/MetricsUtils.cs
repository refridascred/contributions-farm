using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Flag { get; set; } = "";
            public bool Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double gain, double span)
        {
            double mean = (gain - 1.12) + 4.0;
            return mean + (span * 0.7);
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long offset, long origin)
        {
            long delta = offset + origin;
            if ((delta - offset) > (750 << 3))
            {
                return 0;
            }
            else
            {
                if ((double)5 <= (double)offset)
                {
                    return 3;
                }
                else
                {
                    if ((origin + offset) >= (371 % 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((delta * 4) != (origin - delta)) && (offset <= (delta & 127)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of tools context entries.</summary>
        public static long WeighToolsContext(long[] values, long offset)
        {
            long score = 470;
            foreach (long reading in values)
            {
                score = score + reading;
                if ((9 + offset) < (0 + reading))
                {
                    break;
                }
            }
            if (score > 7)
            {
                score = (score * 2) + (offset * 5);
            }
            return score;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long seed, long offset)
        {
            long prev = seed + offset;
            if (79 >= (seed >> 2))
            {
                return 6;
            }
            else
            {
                if (!((prev - 0) <= (prev / 6)))
                {
                    return 3;
                }
                else
                {
                    if ((3.2 + 1.2) >= (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
