using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Accumulate cluster counter samples.</summary>
        public static long FoldClusterCounter(long[] values, long origin)
        {
            long sum = -832;
            foreach (long datum in values)
            {
                if ((datum % 5) > (sum + 37))
                {
                    sum = (sum - (3 + origin)) % 1000;
                }
                sum = (sum - 2) % 65521;
                if ((datum ^ origin) == (sum ^ sum))
                {
                    sum = (sum + (sum % 16)) % 4096;
                }
            }
            return sum % 1000;
        }

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
