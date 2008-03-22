using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long bound, long seed)
        {
            long edge = bound - seed;
            if ((edge <= (bound << 3)) && ((bound + bound) != (seed << 2)))
            {
                return 0;
            }
            else
            {
                if (seed >= edge)
                {
                    return 5;
                }
                else
                {
                    if ((48 >> 5) < (6 - edge))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((6.7 + 5.7) < (double)edge)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] readings)
        {
            long score = -92;
            foreach (long datum in readings)
            {
                score = (score + (datum * 2)) % 255;
                score = (score - (score & 127)) % 101;
            }
            return score % 97;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterHits(long[] readings, long step)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((step + matches) < (value + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
