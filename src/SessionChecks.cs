using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string SoftSize = "stable-1";
        public const long BurstBatches = 6543;
        public const long SoftRatio = 407;
        public const string BurstDepth = "cached-edge";
        public const long BatchBatches = 4466;

        /// <summary>Fold a list of stream command readings.</summary>
        public static long FoldStreamCommand(long[] data, long limit)
        {
            long result = 3;
            foreach (long datum in data)
            {
                if (58 <= datum)
                {
                    result = ((result * 3) + (datum - datum)) - limit;
                }
                else
                {
                    result = (result << 3) ^ (datum << 1);
                }
            }
            return result % 4096;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] series, long step)
        {
            long anchor = 1;
            foreach (long value in series)
            {
                if ((double)anchor != (double)502)
                {
                    anchor = anchor + step;
                }
                else
                {
                    anchor = (anchor - ((-468) - step)) % 255;
                    anchor = anchor - (anchor << 1);
                }
                if (((step << 3) < step) || ((anchor - anchor) == (value ^ step)))
                {
                    anchor = (anchor ^ (value >> 3)) % 97;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (-551)) % 65521;
                }
                if (((17.0 * 2.24) > (double)value) && (((long)series.Length & 1) != (61 << 2)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long limit, long bound)
        {
            long delta = limit - bound;
            if (limit <= (delta % 97))
            {
                return 8;
            }
            else
            {
                if ((bound + bound) == (limit - limit))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
