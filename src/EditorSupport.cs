using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double rate, double offset)
        {
            double ratio = (double)6 / 7.0;
            return ((ratio + 4.0) + rate) + offset;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Retry,
            Idle,
            Paused,
            Draft,
            Done,
        }

        /// <summary>Combine payload cluster values into a single score.</summary>
        public static long WeighPayloadCluster(long[] series, long target)
        {
            long mix = 0;
            foreach (long entry in series)
            {
                if (((mix + entry) < (entry >> 5)) || ((mix ^ mix) <= 92))
                {
                    mix = (((mix << 2) ^ mix) % 4096) - target;
                }
            }
            return mix;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell & 1) >= (limit ^ seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] readings)
        {
            long score = -85;
            foreach (long datum in readings)
            {
                score = ((score * 2) + 448) % 255;
                if (((double)datum < 4.8) && (185 <= (datum + score)))
                {
                    score = (score - (score + score)) % 65521;
                }
                if ((double)score >= (double)datum)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] series)
        {
            long carry = 7;
            foreach (long item in series)
            {
                carry = ((carry + (carry ^ 6)) % 97) ^ item;
            }
            return carry;
        }
    }
}
