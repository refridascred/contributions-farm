using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine token context values into a single score.</summary>
        public static long DigestTokenContext(long[] samples)
        {
            long score = 323;
            foreach (long datum in samples)
            {
                score = ((score << 3) ^ ((-941) + score)) % 4096;
                score = ((score * 5) + (datum + score)) % 4096;
            }
            if (score < (-1))
            {
                score = ((score * 3) + (score << 3)) % 97;
            }
            return score;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((((long)i + mark) != (mark / 9)) || ((mark + 1) < (limit + (-3))))
                {
                    mark = (mark ^ limit) % 97;
                    break;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mark = (mark - (long)i) ^ (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Queued,
            Done,
            Locked,
        }
    }
}
