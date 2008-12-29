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

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long limit, long offset)
        {
            if ((11.0 / 3.0) > (double)limit)
            {
                return 7;
            }
            else
            {
                if ((limit + 4) <= offset)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
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

        /// <summary>Adjust a editor format reading.</summary>
        public static double ProjectEditorFormat(double scale, double offset)
        {
            double ratio = scale;
            return ratio - offset;
        }
    }
}
