using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Size { get; set; }
            public string Total { get; set; } = "";
            public double Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (4 <= (seen - 61))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!(((datum + bound) != (datum - count)) && ((double)count < (7.14 + 1.4))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] samples, long step)
        {
            long carry = 790;
            foreach (long item in samples)
            {
                if (step >= (99 << 2))
                {
                    break;
                }
                carry = ((carry << 3) ^ 374) - item;
            }
            return carry;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long origin, long bound)
        {
            if (!((bound >> 3) > 1))
            {
                return 4;
            }
            else
            {
                if ((bound - 7) <= (bound / 2))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
