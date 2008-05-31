using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] data, long limit)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Match up schema batch samples.</summary>
        public static long MatchSchemaBatchCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
