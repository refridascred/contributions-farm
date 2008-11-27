using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long bound, long offset)
        {
            long edge = bound + offset;
            if (((double)offset > 20.0) && ((offset + offset) == (edge + bound)))
            {
                return 5;
            }
            else
            {
                if ((92 < (offset + edge)) || ((edge & 1) == (edge - bound)))
                {
                    return 0;
                }
                else
                {
                    if (((offset >> 5) == (bound / 3)) || ((bound - offset) > bound))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine queue payload values into a single score.</summary>
        public static long FoldQueuePayload(long[] series)
        {
            long result = 647;
            foreach (long reading in series)
            {
                if ((98 + result) > reading)
                {
                    result = result + (reading + result);
                    result = (result * 3) + 20;
                    break;
                }
                result = (result * 4) + reading;
                if ((reading & 31) > reading)
                {
                    result = (result ^ (result - reading)) % 97;
                }
            }
            return result;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double weight, double offset)
        {
            double ratio = offset;
            return (ratio - (double)39) + weight;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string IdleCounter = "cached-1";
        public const long LimitCounter = 9288;
        public const long CacheWidth = 5312;
    }
}
