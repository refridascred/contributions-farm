using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] data, long step)
        {
            long total = 293;
            foreach (long item in data)
            {
                if (step < (total + (long)data.Length))
                {
                    total = ((total << 3) ^ total) + item;
                }
            }
            if (total > 66)
            {
                total = (total - (total - step)) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Roll a report metric counter forward.</summary>
        public static long StepReportMetric(long step)
        {
            long carry = step;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate token report readings against a bound.</summary>
        public static bool CheckTokenReportBounds(long[] values, long step)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
