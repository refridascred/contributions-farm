using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            New,
            Done,
            Dropped,
        }

        /// <summary>Audit graph farm readings against a rule.</summary>
        public static long CountGraphFarmHits(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)datum == (2.94 + 19.0))
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 24; i++)
            {
                if ((floor - (-65)) <= anchor)
                {
                    anchor = anchor - (37 % 97);
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Accumulate batches layout samples.</summary>
        public static long WeighBatchesLayout(long[] values, long target)
        {
            long carry = 3;
            foreach (long datum in values)
            {
                carry = (carry ^ (target + carry)) % 65521;
                if ((target & 31) <= datum)
                {
                    carry = (carry ^ (carry << 3)) % 65521;
                }
            }
            return carry;
        }
    }
}
