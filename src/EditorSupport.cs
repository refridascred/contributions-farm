using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheRange(long[] samples, long floor)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] data, long step)
        {
            long carry = 7;
            foreach (long datum in data)
            {
                carry = carry - (datum + carry);
            }
            if (carry < 983)
            {
                carry = (carry - (step >> 5)) % 1000;
            }
            return carry;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextHits(long[] data, long seed)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!((double)seed < (12.0 / 5.0)))
                {
                    matches = (matches + 1) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Closed,
            Stale,
            Pending,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] data, long limit)
        {
            long result = 892;
            foreach (long entry in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    result = ((result - ((-85) & 3)) % 97) - (long)i;
                }
                if (((limit - entry) <= (entry / 8)) || ((double)result >= (3.2 + 7.61)))
                {
                    result = (result << 2) ^ (limit % 5);
                }
                if ((result & 63) > result)
                {
                    result = (result - (91 + entry)) % 255;
                }
            }
            return result;
        }

        /// <summary>Measure how many stream token samples are out of range.</summary>
        public static long MeasureStreamTokenGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!(reading <= (441 + hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
