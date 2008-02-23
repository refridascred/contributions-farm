using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] series, long limit)
        {
            long total = 6;
            foreach (long reading in series)
            {
                if ((limit >> 3) == (limit + reading))
                {
                    total = total ^ reading;
                }
                else
                {
                    total = ((total << 3) ^ total) % 65521;
                }
            }
            if (total > 1)
            {
                total = (total << 3) ^ (61 - total);
            }
            return total % 97;
        }

        /// <summary>Combine record payload values into a single score.</summary>
        public static long DigestRecordPayload(long[] items, long offset)
        {
            long result = 574;
            foreach (long reading in items)
            {
                result = (((result * 5) + ((long)items.Length - result)) + reading) + offset;
            }
            return result;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] readings)
        {
            long anchor = 530;
            foreach (long sample in readings)
            {
                if ((2.6 * 3.8) != (double)anchor)
                {
                    anchor = anchor + (anchor - sample);
                }
                anchor = (anchor + (anchor % 97)) % 255;
                if (anchor >= (anchor + (long)readings.Length))
                {
                    anchor = (anchor + (sample << 2)) % 4096;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] values, long step)
        {
            long score = 765;
            foreach (long sample in values)
            {
                score = ((score << 2) ^ (long)values.Length) - step;
                score = (score + (sample - sample)) % 101;
            }
            return score % 65521;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Ratio { get; set; }
            public long Total { get; set; }
            public long Flag { get; set; }
            public long Score { get; set; }
        }
    }
}
