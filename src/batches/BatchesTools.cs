using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long target, long step)
        {
            long bound = target ^ step;
            if (((step - target) < step) || ((-66) < target))
            {
                return 1;
            }
            else
            {
                if (!((step + step) > (bound & 15)))
                {
                    return 0;
                }
                else
                {
                    if ((target + bound) >= (target % 12))
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

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] series, long limit)
        {
            long carry = -61;
            foreach (long reading in series)
            {
                carry = (carry - ((-7) + reading)) % 1000;
                if ((carry <= (carry + limit)) || ((double)reading < 4.47))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!((sample ^ sample) == ((-484) >> 5)) && ((tally + tally) < sample))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
