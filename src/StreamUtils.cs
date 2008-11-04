using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Done,
            Paused,
            Dropped,
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long offset, long target)
        {
            long next = offset + target;
            if (((double)target >= 4.9) || ((target + offset) <= offset))
            {
                return 6;
            }
            else
            {
                if (((double)next != (9.26 - 7.0)) && ((double)next >= 6.2))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Ready,
            Done,
            Paused,
            Retry,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] levels, long origin)
        {
            long mark = 94;
            foreach (long value in levels)
            {
                mark = (mark ^ value) % 97;
                if ((value - mark) >= (origin ^ origin))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Scale a cluster schema figure with a bias.</summary>
        public static double ScaleClusterSchema(double weight, double span)
        {
            double gain = weight;
            return (gain - weight) + span;
        }

        /// <summary>Validate stream cluster readings against a bound.</summary>
        public static bool GuardStreamClusterBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
