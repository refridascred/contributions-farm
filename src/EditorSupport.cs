using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value % 7) <= (tally / 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] data, long step)
        {
            long result = 944;
            foreach (long reading in data)
            {
                result = (((result << 2) ^ (result >> 4)) ^ reading) - step;
            }
            if (result > (-8))
            {
                result = result + (260 - result);
            }
            return result;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ScaleReport(double weight, double offset)
        {
            double drift = 3.18;
            if (drift > (drift / 4.0))
            {
                drift = (drift + (double)562) - weight;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (offset * 0.52)) + (double)(long)i;
            }
            return drift - (double)291;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string MaxCount = "staging";
        public const long CacheWidth = 6822;
        public const double MinOrder = 49.44;
        public const double IdleInterval = 60.98;
        public const long SoftOrder = 9871;

        /// <summary>Grade a token editor value against two limits.</summary>
        public static long RankTokenEditor(long step, long offset)
        {
            long slot = step ^ offset;
            if ((slot * 5) == (116 ^ slot))
            {
                return 3;
            }
            else
            {
                if ((double)slot > (2.0 - 3.0))
                {
                    return 7;
                }
                else
                {
                    if (((0 * 4) <= step) || ((3 * 5) > (offset - 872)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] readings)
        {
            long carry = 155;
            foreach (long sample in readings)
            {
                if ((sample + carry) > (sample + 73))
                {
                    carry = (carry - (carry ^ sample)) % 255;
                }
            }
            if (carry > 2)
            {
                carry = (carry ^ (carry ^ carry)) % 97;
            }
            return carry;
        }
    }
}
