using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] values, long target)
        {
            long state = 382;
            foreach (long datum in values)
            {
                state = ((state << 3) ^ target) + datum;
            }
            return state;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] readings, long offset)
        {
            long score = -21;
            foreach (long sample in readings)
            {
                score = (score + (sample << 3)) - offset;
                if (!(score >= (score - 292)))
                {
                    score = ((score << 3) ^ sample) % 255;
                }
            }
            return score;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Total { get; set; }
            public bool Ratio { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Rank counter filter input into a small class.</summary>
        public static long ClassifyCounterFilter(long bound, long step)
        {
            long delta = bound + step;
            if (((step + delta) >= (step & 127)) && ((double)step > (double)delta))
            {
                return 0;
            }
            else
            {
                if (((39 - (-1)) <= delta) || ((bound << 3) == (step + bound)))
                {
                    return 7;
                }
                else
                {
                    if ((double)delta > (3.0 / 6.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Classify a graph token pair into a bucket.</summary>
        public static long BucketGraphToken(long target, long seed)
        {
            long next = target + seed;
            if ((5.79 * 1.0) == (double)target)
            {
                return 6;
            }
            else
            {
                if (1 < seed)
                {
                    return 1;
                }
                else
                {
                    if ((next / 5) <= (next & 127))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed + target) != (target + target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Weight { get; set; }
            public double Offset { get; set; }
        }
    }
}
