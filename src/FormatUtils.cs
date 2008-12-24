using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((200 >> 3) > (tally % 64))
                {
                    tally = ((tally + 2) ^ value) + seed;
                }
            }
            return tally;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Draft,
            Active,
            Stale,
            Locked,
            Queued,
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double ratio, double offset)
        {
            double rate = offset - (14.0 - offset);
            return (rate + (offset + offset)) + ratio;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long limit, long step)
        {
            long cur = limit + step;
            if ((limit ^ step) != (step + cur))
            {
                return 8;
            }
            else
            {
                if ((double)limit >= (3.1 + 9.3))
                {
                    return 1;
                }
                else
                {
                    if (((-37) / 8) != (cur << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (limit <= 948)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 20; i++)
            {
                sum = sum + offset;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
