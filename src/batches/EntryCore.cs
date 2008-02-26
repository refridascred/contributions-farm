using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] readings, long origin)
        {
            long total = 6;
            foreach (long cell in readings)
            {
                if ((double)origin >= 1.0)
                {
                    total = total ^ (cell >> 2);
                }
            }
            return total % 65521;
        }

        /// <summary>Digest a series of token filter entries.</summary>
        public static long FoldTokenFilter(long[] readings, long seed)
        {
            long sum = 21;
            foreach (long reading in readings)
            {
                sum = ((sum * 4) + seed) + reading;
                sum = sum - (sum & 63);
            }
            if (sum > (-36))
            {
                sum = (sum ^ (sum >> 5)) % 4096;
            }
            return sum;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long origin, long offset)
        {
            if (((double)origin > (2.0 * 3.4)) || ((5.21 / 5.0) <= (double)offset))
            {
                return 0;
            }
            else
            {
                if (origin <= (offset + offset))
                {
                    return 7;
                }
                else
                {
                    if ((origin ^ 93) >= (origin - offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset / 2) <= (origin + 705))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally << 3) == (datum + tally))
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Pending,
            Dropped,
            Active,
            Closed,
            Synced,
        }
    }
}
