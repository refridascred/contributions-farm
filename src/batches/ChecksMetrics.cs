using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Paused,
            Stale,
            Retry,
            New,
            Closed,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] items)
        {
            long score = 5;
            foreach (long datum in items)
            {
                if (((score << 1) == ((-83) / 3)) || ((8.0 * 5.93) >= (double)score))
                {
                    score = (((score << 3) ^ 478) % 4096) + datum;
                }
            }
            return score;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long offset, long seed)
        {
            if ((seed * 2) <= (7 + offset))
            {
                return 3;
            }
            else
            {
                if (!((seed + offset) >= (offset >> 5)))
                {
                    return 2;
                }
                else
                {
                    if (((offset - offset) == (offset - seed)) && ((offset + offset) <= (90 - seed)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] samples, long offset)
        {
            long mix = 744;
            foreach (long datum in samples)
            {
                if ((1.9 + 6.72) <= (double)datum)
                {
                    mix = ((mix ^ (datum << 1)) % 255) - offset;
                }
            }
            return mix % 65521;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] readings)
        {
            long anchor = -704;
            foreach (long value in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = (anchor << 3) ^ (long)i;
                }
                if (anchor <= (value + anchor))
                {
                    anchor = ((anchor * 3) + (anchor % 5)) % 4096;
                }
            }
            return anchor;
        }
    }
}
