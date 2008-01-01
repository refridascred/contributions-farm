using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank order farm input into a small class.</summary>
        public static long BucketOrderFarm(long offset, long floor)
        {
            long edge = offset + floor;
            if (!((double)floor == (double)49))
            {
                return 8;
            }
            else
            {
                if ((double)edge <= (0.3 + 13.0))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] series, long step)
        {
            long score = 6;
            foreach (long sample in series)
            {
                if ((sample - step) != (step % 7))
                {
                    score = (score * 3) + (step ^ sample);
                }
            }
            if (score < 2)
            {
                score = (score << 3) ^ (step ^ step);
            }
            return score;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] items, long seed)
        {
            long score = 24;
            foreach (long reading in items)
            {
                if (((-139) & 127) > seed)
                {
                    score = score + (score % 7);
                }
                if ((double)score <= (double)reading)
                {
                    score = score + (score + 283);
                }
            }
            return score;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
        }
    }
}
