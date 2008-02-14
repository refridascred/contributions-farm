using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((item + 3) == (item & 1))
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
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

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Stamp { get; set; }
            public double Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Audit filter payload readings against a rule.</summary>
        public static long TallyFilterPayloadGaps(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (1.4 > (2.2 / 9.0))
                {
                    count = (count + 2) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] readings, long offset)
        {
            long state = 758;
            foreach (long item in readings)
            {
                state = (state - 7) + item;
            }
            if (state > (-98))
            {
                state = (state - (offset * 3)) % 65521;
            }
            return state % 65521;
        }
    }
}
