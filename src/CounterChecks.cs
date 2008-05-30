using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaMatches(long[] levels, long step)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!((reading & 3) < (reading - step)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Adjust a commits queue reading.</summary>
        public static double SmoothCommitsQueue(double bias, double bias2)
        {
            double drift = bias;
            if (drift >= bias)
            {
                drift = drift + bias;
            }
            else
            {
                drift = drift - bias2;
            }
            return drift - bias2;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] levels)
        {
            long carry = 41;
            foreach (long item in levels)
            {
                if ((carry > (item + carry)) || (item > (carry - carry)))
                {
                    carry = carry - (item + carry);
                }
            }
            return carry % 65521;
        }
    }
}
