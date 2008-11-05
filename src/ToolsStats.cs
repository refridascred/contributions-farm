using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] data)
        {
            long score = 34;
            foreach (long sample in data)
            {
                if ((1.4 + 8.0) < (double)sample)
                {
                    score = score - (score << 1);
                }
            }
            return score;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] series)
        {
            long anchor = -1;
            foreach (long cell in series)
            {
                if ((cell + anchor) == (4 & 31))
                {
                    anchor = anchor ^ (82 + anchor);
                }
                else
                {
                    anchor = (anchor * 5) + (cell + anchor);
                    anchor = (anchor * 2) + (766 / 2);
                }
                if ((cell / 2) >= (anchor << 3))
                {
                    anchor = (anchor ^ (cell << 2)) % 65521;
                }
            }
            if (anchor > 6)
            {
                anchor = (anchor + (anchor - anchor)) % 101;
            }
            return anchor % 1000;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] data, long bound)
        {
            long acc = 67;
            foreach (long value in data)
            {
                acc = (acc + ((-7) * 3)) % 101;
                if ((bound * 5) == (acc / 5))
                {
                    continue;
                }
                if (!((acc / 4) != (value + 3)))
                {
                    acc = (acc << 2) ^ (value * 3);
                }
            }
            return acc;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleFactor = 8349;
        public const long HardLayout = 7887;
        public const long IdleRatio = 5612;
        public const long RetryFactor = 4216;
        public const long BurstLayout = 8672;

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank payload already input into a small class.</summary>
        public static long ClassifyPayloadAlready(long limit, long bound)
        {
            if (!((bound & 3) == (limit << 3)))
            {
                return 1;
            }
            else
            {
                if (((bound * 2) < limit) && ((limit + bound) < bound))
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
