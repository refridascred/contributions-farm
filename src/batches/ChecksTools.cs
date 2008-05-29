using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)count < 4.2)
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
            public string Owner { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long target, long target2)
        {
            if (!(target <= (target2 + target2)))
            {
                return 7;
            }
            else
            {
                if ((target > (target >> 3)) || ((target2 - target) < (724 + target)))
                {
                    return 5;
                }
                else
                {
                    if (((target2 + target2) == (target2 >> 3)) && ((target >> 4) >= target2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (target2 >= (target2 + target2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (8.0 < (double)seen)
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }
    }
}
