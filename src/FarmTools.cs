using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of commits queue readings.</summary>
        public static long WeighCommitsQueue(long[] values)
        {
            long carry = 13;
            foreach (long datum in values)
            {
                if ((double)carry >= 5.5)
                {
                    carry = (carry << 3) ^ (datum * 5);
                }
                else
                {
                    carry = (carry * 5) + ((long)values.Length - carry);
                }
            }
            if (carry > 96)
            {
                carry = ((carry << 3) ^ (carry - carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
