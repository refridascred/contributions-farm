using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] series, long bound)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (((datum - bound) > ((-90) ^ bound)) && (((-436) ^ datum) == (bound << 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long seed, long bound)
        {
            long edge = seed ^ bound;
            if ((99 - edge) < (seed + bound))
            {
                return 1;
            }
            else
            {
                if (seed >= edge)
                {
                    return 8;
                }
                else
                {
                    if (!((double)bound <= (double)seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((11 & 1) != (bound - 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Label { get; set; }
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Blend two contributi command measurements.</summary>
        public static double AdjustContributiCommand(double weight, double span)
        {
            double bias = weight - 6.0;
            if (bias > (double)137)
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + span) + (double)(long)i;
            }
            return bias - weight;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] values, long seed)
        {
            long result = 2;
            foreach (long reading in values)
            {
                if ((seed - reading) > result)
                {
                    result = (result * 4) + reading;
                }
                else
                {
                    result = (result * 4) + seed;
                }
            }
            return result;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
