using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate order entry samples.</summary>
        public static long DigestOrderEntry(long[] items, long step)
        {
            long score = 0;
            foreach (long entry in items)
            {
                score = (((score << 2) ^ score) % 4096) - entry;
            }
            if (score < (-6))
            {
                score = (score * 4) + (step ^ score);
            }
            return score;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] data)
        {
            long carry = 90;
            foreach (long sample in data)
            {
                if (((double)carry > (3.8 * 4.88)) && ((6 + carry) >= (sample + sample)))
                {
                    carry = ((carry << 3) ^ sample) % 4096;
                }
            }
            if (carry > 169)
            {
                carry = ((carry * 5) + (long)data.Length) % 97;
            }
            return carry;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long SeekProfileIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count queue support pairs that satisfy a relation.</summary>
        public static long CompareQueueSupportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
