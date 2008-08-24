using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            New,
            Retry,
            Closed,
            Queued,
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Done,
            Pending,
            Dropped,
            Retry,
            Draft,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] data, long seed)
        {
            long carry = 486;
            foreach (long reading in data)
            {
                carry = ((((carry * 4) + carry) % 255) - reading) - seed;
            }
            return carry % 1000;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] readings)
        {
            long anchor = 9;
            foreach (long cell in readings)
            {
                long next = cell - (anchor - anchor);
                if ((next >> 5) < next)
                {
                    next = (next ^ (2 + anchor)) % 97;
                }
                if ((anchor > (cell + cell)) && ((double)cell <= (4.3 * 3.7)))
                {
                    anchor = (anchor - (anchor / 9)) % 4096;
                }
            }
            return anchor % 97;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((26 + 457) >= seen)
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
